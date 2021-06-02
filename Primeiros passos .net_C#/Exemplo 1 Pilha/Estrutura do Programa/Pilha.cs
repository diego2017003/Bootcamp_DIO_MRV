using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_do_Programa
{
    class Pilha//classe para uma pilha escrita como uma lista encadeada 
    {
        Posicao primeiro;//classe para o elemento no topo da pilha

        public Pilha()//contrutor padrão para o primeiro ser inicializado
        {
            primeiro = null;
        }
        public Pilha(Posicao primeiro) {
            this.primeiro = primeiro;//inicializa o primeiro elemento no topo da pilha de acordo com o parâmetro recebido
        }
        public void Empilha(object item)//insere um novo elemento no top da pilha
        {
            this.primeiro = new Posicao(primeiro, item);//inicializa um novo elemento da pilha como uma lista encadeada
        }
        public object Desempilha() //retira o elemento no topo da pilha
        {
            if (this.primeiro == null) {//tratamento de exceção em pilha vazia
                throw new InvalidOperationException("A pilha está vazia");
            }
            object saida = this.primeiro.item;//o elemento que está saindo da pilha
            this.primeiro = primeiro.proximo;//atualização do elemento no topo da pilha
            return saida;
        }
    }

    internal class Posicao//classe para cada elemento dentro da pilha
    {
        public Posicao proximo;//"referência" para o elemento abaixo
        public object item;//valor do elemento 
        public Posicao(Posicao proximo,object item)//construtor parametrizado para os elementos da pilha
        {
            this.proximo = proximo;
            this.item = item;
        }
    }
}
