using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodAlunos
{
    class Seguranca
    {
        

        public string decripta(String dado)
        {
            string aux = dado.Substring(0, 8);
            dado = dado.Substring(8, 3);

            int cont = 0;
            int[] dadonum = new int[3];
            int[] chave = { 20, 13, 21 };
            string[] dadoalfa = new string[3];
            string[] alfa = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };


            for (int i = 0; i <= 2; i++)                            //faz a decriptação do dado letra a letra
            {
                dadoalfa[i] = dado.Substring(i, 1);

                while (dadoalfa[i] != alfa[cont])
                    cont++;
                dadonum[i] = (num[cont] - chave[i] + 25) % 25;        //descobre o valor da letra e faz a soma dos valores para a encriptacao

                dadoalfa[i] = alfa[dadonum[i]];                     //transforma o valor em letra

                cont = 0;

            }

            dado = aux + String.Concat(dadoalfa);

            return dado;
            //20 13 21
            //U  N  V

        }



        public string encripta(String dado)
        {
            
            int cont = 0;
            int[] dadonum = new int[3];
            int[] chave = { 20, 13, 21 };
            string[] dadoalfa = new string[3];
            string[] alfa = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };



            for (int i = 0; i <= 2; i++)                            //faz a encriptação do dado letra a letra
            {
                dadoalfa[i] = dado.Substring(i, 1);

                while (dadoalfa[i] != alfa[cont])
                    cont++;

                dadonum[i] = (num[cont] + chave[i]) % 25;             //descobre o valor da letra e faz a soma dos valores para a encriptacao

                dadoalfa[i] = alfa[dadonum[i]];                     //transforma o valor em letra

                cont = 0;

            }

            dado = String.Concat(dadoalfa);

            return dado;
            //20 13 21
            //U  N  V  



        }
    }
}
