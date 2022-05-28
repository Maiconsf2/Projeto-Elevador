using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class ElevadorDescendo
    {
        private readonly int andarDesejado;
        internal readonly Elevador elevador;

        public ElevadorDescendo(int andarDesejado, Estado estado)
            : this(estado.andarAtual, estado.controle, estado.elevador)
        {
            andarDesejado = andarDesejado;
        }

        private ElevadorDescendo(int andarAtual, bool[] controle, Elevador elevador)
        {
           andarAtual = andarAtual;
           controle = controle;
           elevador = elevador;
        }

        public ElevadorDescendo(int andarDesejado, ElevadorParado elevadorParado)
        {
        }

        public override string MovimentarElevador()
        {
            var mensagem = string.Empty;

            if (andarDesejado < 1 || andarDesejado > elevador.ObterAndares())
                return "Andar inválido.";

            int andarAtual = 0;
            for (int i = andarAtual; i >= 1; i--)
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
