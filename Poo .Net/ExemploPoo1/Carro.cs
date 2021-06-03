using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPoo1
{
    class Carro
    {
        public int nPortas;
        public string marca;
        public string modelo;
        public string ano;
        public Cor cor;
        private int velocidade;
        public int orientacao;//orientação do carro em torno do próprio eixo considerando como parâmetro a proentação inicial como 0
        private static float velocidadeMax = 300;
        public Carro() {
            this.cor = Cor.Vermelho;
            this.nPortas = 2;
            this.marca = "Ferrari";
            this.modelo = "Carrão";
            this.ano = "2021";
            this.velocidade = 0;
        }
        public Carro(Cor cor,int nPortas,string marca,string modelo,string ano)
        {
            this.cor = cor;
            this.nPortas = nPortas;
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.velocidade = 0;
        }
        public float getVelocidade() {
            return this.velocidade;
        }
        public void setVelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }
        public void ligar() {
            this.orientacao = 0;
        }
        public void acelerar(int velocidade) {
            if (velocidade > this.velocidade)
            {
                for (int i = this.velocidade; i < velocidade; i++)
                {
                    this.velocidade = i;//vai incrementando velocidade atual do carro até a desejada
                }
            }
            else {
                this.desacelerar(velocidade);
            }
        
        }
        public void desacelerar(int velocidade)
        {
            if (velocidade < this.velocidade)
            {
                if (velocidade < velocidadeMax)
                {
                    for (int i = this.velocidade; i > velocidade; i--)
                    {
                        this.velocidade = i;//vai incrementando velocidade atual do carro até a desejada
                    }
                }
                else {
                    Console.WriteLine("Velocidade inacançavel pelo carro");
                }
            }
            else
            {
                this.acelerar(velocidade);
            }

        }
        public void estacionar() {
            this.desacelerar(0);
        }
        public void virar_A_Direita(int angulo) {//vira o orientação em sentido horário
            this.orientacao = this.orientacao + angulo;
        }
        public void virar_A_Esquerda(int angulo)//vira a orientação em sentido anti-Horário
        {
            this.orientacao = this.orientacao - angulo;
        }
        public void Dar_Re() {
            this.velocidade = -10;//andando contra o sentido normal com velocidade especifica do modelo 
        }
    }
}
