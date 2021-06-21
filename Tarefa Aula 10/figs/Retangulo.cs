using System;

namespace TarefaHE
{
    public class Retangulo : Figuras
    {
        private double _alt;
        private double _l;

        private void AttA()
        {
            this._a = this._alt * this._l;
        }
        private void AttP()
        {
            this._p = 2 * (this._alt + this._l);
        }

        public Retangulo(double l, double alt)
        {
            this._nome = "Retangulo";

            this._l = l;
            this._alt = alt;

            this.AttP();
            this.AttA();
        }
    }
}