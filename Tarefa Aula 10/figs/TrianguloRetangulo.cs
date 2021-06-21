using System;

namespace TarefaHE
{
    public class TrianguloRetangulo : Figuras
    {
        private double _c1;
        private double _c2;
        private double _l1;
        private double _l2;
        private double _l3;

        private void AttA()
        {
            this._a = (this._c2 * this._c1) / 2;
        }

        private void AttP()
        {
            this._p = this._l1 + this._l2 + this._l3;
        }

        public TrianguloRetangulo(double a, double p)
        {
            this._nome = "Triangulo Retangulo";

            this._a = a;
            this._p = p;

            this.AttA();
            this.AttP();
        }

    }
}