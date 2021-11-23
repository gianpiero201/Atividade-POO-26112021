using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_POO_12112021_GIANPIEROGIGLIO
{
    internal class ListaAlunos
    {
        List<Alunos> listalunos = new List<Alunos>();
        public void AdicionarAlunos(Alunos aluno)
        {
            this.listalunos.Add(aluno);
        }
        public void RemoverAlunos(Alunos aluno)
        {
            this.listalunos.Remove(aluno);
        }
    }
}
