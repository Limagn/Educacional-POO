using System.Configuration;

namespace Academico.Models
{
	public class Disciplina
	{
		public int DisciplinaID { get; set; }
		public string Name { get; set; }

		[IntegerValidator(MinValue = 10, MaxValue = 50)]
		public int CargaHoraria { get; set; }
		public ICollection<CursoDisciplina>? CursosDisciplinas { get; set; }
		public ICollection<Aluno>? Alunos { get; set; }
	}
}
