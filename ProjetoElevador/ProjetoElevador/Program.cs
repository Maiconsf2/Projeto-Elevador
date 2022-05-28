using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usuario vai informar o que o programa deve fazer.

            //Tera algumas opcoes de escolha.

            bool continuar = true;

            do
            {

                Console.WriteLine(@"Escolha uma opção:
                                      1 - Inicializar
                                      2 - Entrar
                                      3 - Sair
                                      4 - Subir
                                      5 - Descer
                                      6 - Exit
                          ");

                string OpcaoEscolhida = Console.ReadLine();

                //Para limpar o console.
                Console.Clear();

                switch (OpcaoEscolhida)
                {

                    case "1": Console.WriteLine("Você escolheu inicializar."); break;
                    case "2": Console.WriteLine("Você escolheu entrar."); break;
                    case "3": Console.WriteLine("Você escolheu sair."); break;
                    case "4": Console.WriteLine("Você escolheu subir."); break;
                    case "5": Console.WriteLine("Você escolher descer."); break;
                    case "6": continuar = false; break;

                    default: Console.WriteLine("Escolha não válida."); break;

                }
            }
            while (continuar);

        }

    }

}
