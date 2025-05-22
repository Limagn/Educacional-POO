using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Instituicao
    {
        public int InstituicaoID { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Endereço")]
        public  string Endereco { get; set; }
		public ICollection<Departamento>? Departamentos { get; set; }
	}
}
