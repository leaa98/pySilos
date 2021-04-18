using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pySilos
{
    class Silo
    {
        private double altura, diametroCircular, radio, area;

        public Silo(double altura, double diametroCircular) {
            this.altura = altura;
            this.diametroCircular = diametroCircular;
            this.radio = diametroCircular / 2;
            this.area = Math.PI * radio * radio;
        }

        public double pAltura
        {
            set { altura = value; }

            get { return altura; }
        }

        public double pDiametroCircular
        {
            set { diametroCircular = value; }

            get { return diametroCircular; }
        }


        public double calcularVolumen() {
            return area * altura;
        }
      
    }
}
