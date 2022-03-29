using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1 = 33;
            double peso1 = 88.50;
            double altura1 = 1.65;
            bool EhDev1 = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            double altura2 = 2.10;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            double altura3 = 1.40;
            bool EhDev3 = false;


            //criando array
            string[] nome = { nome1, nome2, nome3 };
            int[] idade = { idade1, idade2, idade3 };
            double[] peso = { peso1, peso2, peso3 };
            double[] altura = { altura1, altura2, altura3 };
            bool[] EhDev = { EhDev1, EhDev2, EhDev3 };

            //Variaveis
            int somaIdade = 0;
            string grupoUbuntu = "";
            string grupoSilva = "";
            int saoDev = 0;
            int contarUbuntuImc = 0;
            double imc = 0;
            double totalImc = 0;
            double mediaImc = 0;


            //T1 - Somar a idade de todos Ubuntus
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("T1 - Somar a idade de todos Ubuntus:");
            for (int contador = 0; contador < nome.Length; contador++)
            {
                bool existe;
                existe = nome[contador].Contains("Ubuntu");
                if (existe)
                {
                    somaIdade = somaIdade + idade[contador];
                }
            }
            Console.WriteLine("Idade Total: " + somaIdade);
            Console.WriteLine("\n");

            //T2 - Agrupar os nomes de todos Ubuntus
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("T2 - Agrupar os nomes de todos Ubuntus:");
            for (int contador = 0; contador < nome.Length; contador++)
            {
                bool existe;
                existe = nome[contador].Contains("Ubuntu");
                if (existe)
                {
                    grupoUbuntu = grupoUbuntu + nome[contador] + "\n";
                }
            }
            Console.WriteLine("São eles: \n " + grupoUbuntu);


            //T3 - Calcular Média dos IMC de todos Ubuntus
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("T3 - Calcular Média dos IMC de todos Ubuntus:");
            for (int contador = 0; contador < nome.Length; contador++)
            {
                bool existe;
                existe = nome[contador].Contains("Ubuntu");
                if (existe)
                {
                    contarUbuntuImc = contarUbuntuImc + 1;
                    imc = peso[contador] / (altura[contador] * altura[contador]);
                    totalImc = totalImc + imc;

                }
            }
            mediaImc = mediaImc + totalImc / contarUbuntuImc;
            Console.WriteLine("Média IMC: " + mediaImc.ToString("f2"));


            //T4 - Contar quantos Ubuntus sao Devs
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("T4 - Contar quantos Ubuntus sao Devs:");
            for (int contador = 0; contador < nome.Length; contador++)
            {
                bool existe;
                existe = nome[contador].Contains("Ubuntu");
                if (existe && EhDev[contador] == true)
                {
                    saoDev = saoDev + 1;
                }
            }
            Console.WriteLine("Total de Ubuntus que são Devs: " + saoDev);
            Console.WriteLine("\n");


            //T5 - Exibir somente Ubuntu com nome Silva
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("T5 - Exibir somente Ubuntu com nome Silva");
            for (int contador = 0; contador < nome.Length; contador++)
            {
                bool existe;
                existe = nome[contador].Contains("Silva");
                if (existe)
                {
                    grupoSilva = grupoSilva + nome[contador] + "\n ";
                }
            }
            Console.WriteLine("São eles:\n " + grupoSilva);
            Console.WriteLine("-----------------------------------------------");

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}