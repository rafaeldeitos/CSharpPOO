using System.Collections.Generic;

namespace CSharpPOO
{
    class Professor : Pessoa
    {
        private double _valorHora;

        public double ValorHora
        {
            get => _valorHora;
            set => _valorHora = value;
        }

        public int Tipo { get; set; }




    }
}
