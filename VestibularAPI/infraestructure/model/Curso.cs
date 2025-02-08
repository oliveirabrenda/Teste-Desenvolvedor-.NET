using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestibularAPI.infraestructure.model;

[Table("Cursos")]
public class Curso : BaseEntity{

    [Column("Nome")]
    [Required]
    [StringLength(150)]
    public string Nome {get; set;} = "";

    [Column("Descricao")]
    [StringLength(500)]
    public string Descricao {get; set;} = "";

    [Column("VagasDisponiveis")]
    public int VagasDisponiveis {get; set;}

    public List<Inscricao> Incricoes {get; set;} = new List<Inscricao>();
}