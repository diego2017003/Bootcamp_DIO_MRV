using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            
            ObterOpcao(ref opcao);
            Instituicao i = new Instituicao();
            while (opcao.ToUpper() != "X") {
                switch (opcao) {
                    case "1":
                        i.InserirAluno();
                        break;
                    case "2":
                        i.ListarAlunos();
                        break;
                    case "3":
                        i.CalcularMediaTotal();
                        i.informaConceito();
                        break;
                    default:
                        Console.WriteLine("Invalido");
                        break;
                }
                ObterOpcao(ref opcao);

            }
        }
        public static void ObterOpcao(ref string opcao) {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1. Inserir novo aluno;");
            Console.WriteLine("2. Listar alunos;");
            Console.WriteLine("3. Calcular média geral;");
            Console.WriteLine("X. Sair.\n");

            opcao = (Console.ReadLine());
        }
    }
}
