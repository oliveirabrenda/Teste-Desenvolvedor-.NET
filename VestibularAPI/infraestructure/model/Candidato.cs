using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestibularAPI.infraestructure.model;

[Table("Candidatos")]
public class Candidato : BaseEntity{

    [Column("Nome")]
    [Required]
    [StringLength(150)]
    public string Nome {get; set;} = "";

    [Column("Email")]
    [StringLength(150)]
    public string Email {get; set;} = "";
    
    [Column("Telefone")]
    [StringLength(20)]
    public string Telefone {get; set;} = "";
    
    [Column("Cpf")]
    [Required]
    [StringLength(14)]
    public string Cpf {get; set;} = "";

    public List<Inscricao> Incricoes {get; set;} = new List<Inscricao>();    
}