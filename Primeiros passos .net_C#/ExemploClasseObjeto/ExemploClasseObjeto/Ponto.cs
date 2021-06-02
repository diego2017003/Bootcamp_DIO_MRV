using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseObjeto
{
    public class Ponto
    {
        public float x, y;
        internal float divisao=0;
        protected float distancia;
        public Ponto() {
            this.x = 0;
            this.y = 0;
        }
        public Ponto(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public float getX() {
            return this.x;
        }
        public float getY()
        {
            return this.y;
        }
        public void setX(float x) {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public void calcularDistancia(Ponto p) {
            float x2 = Math.Abs(p.getX()-this.x);
            float y2 = Math.Abs(p.getY() - this.y);
            this.distancia = (float)Math.Sqrt(x2 * x2 + y2 * y2);
            Console.WriteLine("A distância é {0:N}", this.distancia);
        }
        public void calcularDistancia(float x,float y)
        {
            float x2 = Math.Abs(x - this.x);
            float y2 = Math.Abs(y - this.y);
            this.distancia = (float)Math.Sqrt(x2 * x2 + y2 * y2);
            Console.WriteLine("A distância é {0:N}", this.distancia);
        }
        public void dividirXPorY(ref float divisao) {
            if (y != 0)
            {
                divisao = this.x / this.y;
            }
            else {
                divisao = float.PositiveInfinity;
            }
        }
       
    }
}
