using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Formula_General
{
    class Metodo
    {
        private int valorA;

        public int ValorA
        {
            get
            {
                return valorA;
            }
            set
            {
                valorA = value;
            }
        }

        private int valorB;

        public int ValorB
        {
            get
            {
                return valorB;
            }
            set
            {
                valorB = value;
            }
        }

        private int valorC;

        public int ValorC
        {
            get
            {
                return valorC;
            }
            set
            {
                valorC = value;
            }
        }

        private string resultado;

        public string Resutado
        {
            get
            {
                return resultado;
            }
            set
            {
                resultado = value;
            }
        }

        

        //metodo
        public string Formula(double a, double b, double c)
        {
            resultado = Convert.ToString(((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
            return resultado;
        }
    }
}
