using System;

namespace TarefaHE
{
    public class Figuras
    {
        protected string _nome;
        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        protected double _p;
        public double P
        {
            get
            {
                return this._p;
            }
        }

        protected double _a;
        public double A
        {
            get
            {
                return this._a;
            }
        }
    }
}