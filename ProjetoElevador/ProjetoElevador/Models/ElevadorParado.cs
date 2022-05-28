using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class ElevadorParado
    {
        internal readonly Elevador elevador;
        public ElevadorParado(Estado estado)
            : this(estado.andarAtual, estado.elevador)
        {
        }

        public ElevadorParado(int andarAtual, Elevador elevador)
        {
            andarAtual = andarAtual;
            elevador = elevador;
            controle = new bool[elevador.ObterAndares() + 1];

            controle[andarAtual] = true;
        }

        public override string MovimentarElevador()
        {
            Console.WriteLine("");
            Console.WriteLine($"Para qual andar você deseja ir?");

            var andarDesejado = elevador.ValidarEntrada();

            int andarAtual = 0;
            if (andarAtual < andarDesejado)
            {
                elevador.estadoAtual = new ElevadorSubindo(andarDesejado, this);
                return "Elevador subindo...";
            }
            else if (andarAtual > andarDesejado)
            {
                elevador.estadoAtual = new ElevadorDescendo(andarDesejado, this);
                return "Elevador descendo...";
            }
            else
                return "O elevador já encontra-se no andar.";
        }
    }

}
