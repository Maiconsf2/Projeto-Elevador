using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal abstract class Estado
    {
        internal readonly Elevador elevador;

        public int current_floor { get; set; } // andar atual
        public int total_floos { get; set; } // total de andares
        public int pax_capacity { get; set; } // capacidade do elevador
        public int  pax_inside { get; set; } // quantas pessaos no elevador

        public Elevador elevator { get; set; }
        public int andarAtual { get; set; }
        public bool[] controle { get; set; }

        public abstract string MovimentarElevador();

        public string PararNoAndar(int andarDesejado)
        {
            controle[andarAtual] = false;
            controle[andarDesejado] = true;
            andarAtual = andarDesejado;

            return ($"Parado no {andarDesejado}º andar.");
        }
    }
}
