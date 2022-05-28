using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class ElevadorSubindo
    {
        private readonly int andarDesejado;
        internal readonly Elevador elevador;

        public ElevadorSubindo(int andarDesejado, Estado estado)
            : this(estado.andarAtual, estado.controle, estado.elevador)
        {
            andarDesejado = andarDesejado;
        }

        private ElevadorSubindo(int andarAtual, bool[] controle, Elevador elevador)
        {
            andarAtual = andarAtual;
            controle = controle;
            elevador = elevador;
        }

        public override string MovimentarElevador()
        {
            var mensagem = string.Empty;

            if (andarDesejado < 1 || andarDesejado > elevador.ObterAndares())
                return "Andar inválido.";

            int andarAtual = 0;
            for (int i = andarAtual; i <= elevador.ObterAndares(); i++)
            {
                if (controle[i])
                {
                    mensagem = pararNoAndar(andarDesejado);
                    elevador.estadoAtual = new ElevadorParado(this);
                    break;
                }
                else
                    continue;
            }

            return mensagem ?? "Andar não encontrado!";
        }

    }

}