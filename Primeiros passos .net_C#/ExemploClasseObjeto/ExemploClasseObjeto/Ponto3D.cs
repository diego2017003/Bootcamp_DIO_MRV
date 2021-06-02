using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseObjeto
{
    public class Ponto3D : Ponto
    {
        float z;

        public Ponto3D(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Ponto3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public float getZ() {
            return this.z;
        }
        public void setZ(float z)
        {
            this.z = z;
        }
        public void calcularDistancia3D(float x,float y,float z) {
            float x2 = x - this.x;
            float y2 = y - this.y;
            float z2 = z - this.z;
            this.distancia = (float)Math.Sqrt(x2*x2 + y2*y2 + z2*z2);
            Console.WriteLine("A distância é {0:N} ", this.distancia);
        }
        public void calcularDistancia3D(Ponto3D p)
        {
            float x2 = p.getX() - this.x;
            float y2 = p.getY() - this.y;
            float z2 = p.getZ() - this.z;
            this.distancia = (float)Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
            Console.WriteLine("A distância é  {0:N}", this.distancia);
        }

    }
}
