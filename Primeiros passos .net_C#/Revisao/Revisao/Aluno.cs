using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Aluno
    {
        public string nome { get; set; }
        public decimal nota { get; set; }
        public Aluno() {
            this.nome = "";
            this.nota = 0;
        }
        public Aluno(string nome,decimal nota)
        {
            this.nome = nome;
            this.nota = nota;
        }
    }
}
