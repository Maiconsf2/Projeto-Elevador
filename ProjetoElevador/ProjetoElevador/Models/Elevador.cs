using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador
    {
        public string Entrar()
        {

        }
        public string Sair()
        {
         
        }
        public string Subir()
        {

        }
        public string Descer()
        {

        }
        
        public Estado estadoAtual;
        private readonly int _andaresDoPredio;
        internal readonly Elevador elevador;

        public Elevador(int andaresDoPredio)
        {
            _andaresDoPredio = andaresDoPredio;
            estadoAtual = new ElevadorParado(1, this); // O 1º andar é o padrão.
        }

        public void IniciarElevador()
        {
            while (true)
                Console.WriteLine(estadoAtual.MovimentarElevador());
        }

        public int ObterAndares()
        {
            return _andaresDoPredio;
        }

        public int ValidarEntrada()
        {
            NovaEntrada:
            var entrada = Console.ReadLine();

            if (entrada == "0")
                Environment.Exit(0);

            if (!int.TryParse(entrada, out int resultado))
            {
                Console.WriteLine("Somente valores numéricos. Informe novamente o andar desejado:");
                goto NovaEntrada;
            }

            else if (resultado < 1 || resultado > _andaresDoPredio)
            {
                Console.WriteLine($"Este elevador vai do 1º ao {_andaresDoPredio}º andar. Informe novamente o andar desejado:");
                goto NovaEntrada;
            }

            return resultado;
        }
    }

}
