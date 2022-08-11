using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //estruturas de controle

        struct _FTRSCAN_FAKE_REPLICA_PARAMETERS
        {
            public bool bCalculated;
            public int nCalculatedSum1;
            public int nCalculatedSumFuzzy;
            public int nCalculatedSumEmpty;
            public int nCalculatedSum2;
            public double dblCalculatedTremor;
            public double dblCalculatedValue;
        }
        struct _FTRSCAN_FRAME_PARAMETERS
        {
            public int nContrastOnDose2;
            public int nContrastOnDose4;
            public int nDose;
            public int nBrightnessOnDose1;
            public int nBrightnessOnDose2;
            public int nBrightnessOnDose3;
            public int nBrightnessOnDose4;
            public _FTRSCAN_FAKE_REPLICA_PARAMETERS FakeReplicaParams;
            public _FTRSCAN_FAKE_REPLICA_PARAMETERS Reserved;
        }
        //fim

        //DLL
        [DllImport("ftrScanAPI.dll")]
        static extern bool ftrScanIsFingerPresent(IntPtr ftrHandle, out _FTRSCAN_FRAME_PARAMETERS pFrameParameters);
        [DllImport("ftrScanAPI.dll")]
        static extern IntPtr ftrScanOpenDevice();
        [DllImport("ftrScanAPI.dll")]
        static extern void ftrScanCloseDevice(IntPtr ftrHandle);
        [DllImport("ftrScanAPI.dll")]
        static extern bool ftrScanSetDiodesStatus(IntPtr ftrHandle, byte byGreenDiodeStatus, byte byRedDiodeStatus);
        [DllImport("ftrScanAPI.dll")]
        static extern bool ftrScanGetDiodesStatus(IntPtr ftrHandle, out bool pbIsGreenDiodeOn, out bool pbIsRedDiodeOn);
        [DllImport("ftrScanAPI.dll")]
        static extern bool ftrScanGetImage(IntPtr ftrHandle, int nDose, byte[] pBuffer);
        [DllImport("ftrScanAPI.dll")]
        static extern bool ftrScanGetFakeReplicaParameters(IntPtr ftrHandle, out _FTRSCAN_FAKE_REPLICA_PARAMETERS pFakeReplicaParams);


        //variáveis
        private IntPtr device;
        public bool Connected { get { return (device != IntPtr.Zero); } }
        private int lastContrast = 0; // Valor do ultimo contraste capturado

        public static int minContrast = 800;


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connected)
                    Dispose();

                MessageBox.Show("inciando leitor");
                device = ftrScanOpenDevice();
                if (device == IntPtr.Zero)
                    MessageBox.Show("leitor n conectado");

            }
            catch (Exception ex)
            {
                device = IntPtr.Zero;

                if (ex.Message.Contains("HRESULT:"))
                    ex = new Exception("Provável execução em 64bit chamando DLL 32bits, force o uso em 32bits x86", ex);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("aguardando dedo");
                var t = new _FTRSCAN_FRAME_PARAMETERS();
                int n = 1;
                bool hasTime = true;
                DateTime dt = DateTime.Now;
                if (ftrScanIsFingerPresent(device, out t))
                {
                    if (t.nContrastOnDose2 > minContrast || !hasTime) // garante que vai pegar o dedo por pior que seja no tempo maximo
                    {
                        MessageBox.Show(" D" + n + ": " + t.nContrastOnDose2);
                        n++;
                        if (!hasTime)
                        {
                            MessageBox.Show(" D" + n + ": " + t.nContrastOnDose2 + " Timeout");

                        }
                        else if (n > 4)
                            MessageBox.Show("ok");
                    }
                    else
                    {
                        lastContrast = t.nContrastOnDose2;
                        MessageBox.Show("-" + t.nContrastOnDose2);
                    }
                }
            }
            catch (Exception doex)
            {
                MessageBox.Show("erro");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var t = new _FTRSCAN_FAKE_REPLICA_PARAMETERS();
                if (ftrScanGetFakeReplicaParameters(device, out t))
                {
                    MessageBox.Show("reconheceu");
                }
                else
                {
                    MessageBox.Show("n reconheceu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro");
            }
                


            }


        }
    }