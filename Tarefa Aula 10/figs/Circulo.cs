using System;

namespace TarefaHE
{
    public class Circulo : Figuras
    {
        public Circulo(double r)
        {
            this._nome = "Círculo";
            this.R = r;
        }

        private void AttA() 
        {this._a = Math.PI * this._r * this._r; }

        private void AttP() 
        { this._p = 2 * Math.PI * this._r; }
        { this._p = 2 * Math.PI * this._r; }

        private double _r;
        public double R
        {
            get {return this._r; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("O valor do raio é inválido");
                }

                else
                {
                    this._r = value;
                    this.AttA();
                    this.AttP();
                }
            }
        }

    }
}