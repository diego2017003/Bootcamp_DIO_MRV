using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Instituicao//classe que irá conter os alunos da aplicação
    {
        public Aluno[] alunos = new Aluno[100];//conjunto de alunos da instituição no máximo 100
        private float mediaTotal;//media total na instituição
        private float somaNotas;//somatorio total das notas dos alunos
        private int QuantidadeDeAlunos;//quantidade total de alunos matriculados
        public Instituicao() {//inicializa os valores numericos com 0 para evitar exceção numérica logo no inicio
            this.mediaTotal = 0;
            this.somaNotas = 0;
            this.QuantidadeDeAlunos = 0;
        }
        public void InserirAluno() {
            if (QuantidadeDeAlunos == 100)//verifica se a instituição tá cheia
            {
                Console.WriteLine("A instituição está cheia");
            }
            else//se a instituição ainda tem vaga tenta inserir um novo registro
            {
                Aluno aluno = new Aluno();//cria um novo aluno
                Console.WriteLine("Digite o nome do aluno:");
                string nome = (Console.ReadLine());
                if (string.IsNullOrEmpty(nome))
                {
                    nome = "não informado";//valor default para quando o usuário informar valor vazio
                }
                aluno.nome = nome;//atribui o nome informado ao atrivuto do aluno
                Console.WriteLine("Digite a nota do aluno:");
                if (decimal.TryParse(Console.ReadLine(), out decimal nota))//verifica se a nota é valida e insere o registro no array alunos
                {
                    aluno.nota = nota;
                    alunos[QuantidadeDeAlunos] = aluno;
                    QuantidadeDeAlunos++;
                    somaNotas = somaNotas + (float)aluno.nota;
                    mediaTotal = somaNotas / (QuantidadeDeAlunos);
                }
                else//exceção de nota mal informada
                {
                    throw new ArgumentException("voce não informou um numero");
                }
            }
        }
        public void ListarAlunos() {
            if (QuantidadeDeAlunos > 0)//verifica se já tem registros
            {
                for (int i = 0; i < QuantidadeDeAlunos; i++)//percorre todos os registros na instituição 
                {
                    Console.WriteLine("aluno : {0}, nota:{1:N}", alunos[i].nome, alunos[i].nota);
                }
            }
            else {//quando a instituição estiver vazia
                Console.WriteLine("A lista está vazia");
            }
        
        }
        public void CalcularMediaTotal()
        {
            float soma =  0;
            if (QuantidadeDeAlunos > 0)//verifica se existem registros
            {
                for (int i = 0; i < QuantidadeDeAlunos; i++)
                {
                    soma = soma + (float)alunos[i].nota;//soma de todas as notas
                }
                float media = soma / (QuantidadeDeAlunos);//calcula a média não ponderada
                this.mediaTotal = media;//atualiza a media total da classe
                Console.WriteLine("A media total foi {0:N}", media);//informa a media
            }
            else //não existem registros
            {
                Console.WriteLine("A lista está vazia");
            }
        }
        public void informaConceito() {
            /*
             Esta função verifica o conceito no qual a instituição se enquadra de acordo com sua media total
            Há uma série de condicionais para verifciar o intervalo em que se encontra a média.    
             */
            if (mediaTotal <= 2) {
                Console.WriteLine(Conceito.E);
            }
            else if(mediaTotal<=4){
                Console.WriteLine(Conceito.D);
            }
            else if (mediaTotal <= 6)
            {
                Console.WriteLine(Conceito.C);
            }
            else if (mediaTotal <= 8)
            {
                Console.WriteLine(Conceito.B);
            }
            else
            {
                Console.WriteLine(Conceito.A);
            }

        }
    }
}
