using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class AcademicoContext : DbContext
    {
        public AcademicoContext(DbContextOptions<AcademicoContext> options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Curso> Cursos { get; set; }
		public DbSet<Disciplina> Disciplinas { get; set; }
		public DbSet<CursoDisciplina> CursosDisciplinas { get; set; }
		public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CursoDisciplina>()
				.HasKey(cd => new { cd.CursoID, cd.DisciplinaID });
			modelBuilder.Entity<CursoDisciplina>()
				.HasOne(cd => cd.Curso)
				.WithMany(c => c.CursosDisciplinas)
				.HasForeignKey(cd => cd.CursoID);
			modelBuilder.Entity<CursoDisciplina>()
				.HasOne(cd => cd.Disciplina)
				.WithMany(d => d.CursosDisciplinas)
				.HasForeignKey(cd => cd.DisciplinaID);

			modelBuilder.Entity<Aluno>()
				.HasMany(e => e.Disciplinas)
				.WithMany(e => e.Alunos)
				.UsingEntity<AlunoDisciplina>
					(j => j.HasKey("AlunoId", "DisciplinaId"));
		}
	}
}
