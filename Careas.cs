using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Careas
    {
        private decimal area;

        public decimal Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public Careas()
        {
            area = 0;
        }
        public decimal Cuadrado(decimal l)
        {
            area = l * l;
            return area;
        }
        public decimal Triangulo(decimal b, decimal h)
        {
            area = (b * h) / 2;
            return area;
        }
        public decimal Rectangulo(decimal b, decimal h)
        {
            area = (b * h);
            return area;
        }
        public decimal Romboide(decimal b, decimal h)
        {
            area = (b * h);
            return area;
        }
        public decimal Rombo(decimal D, decimal d)
        {
            area = (D * d);
            return area;
        }
        public decimal Poligono(decimal p, decimal a)
        {
            area = (p * a) / 2;
            return area;
        }
    }
}
