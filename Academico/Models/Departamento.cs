using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Instituição")]
        public int InstituicaoID { get; set; }
        public Instituicao? Instituicao { get; set; }
    }
}
