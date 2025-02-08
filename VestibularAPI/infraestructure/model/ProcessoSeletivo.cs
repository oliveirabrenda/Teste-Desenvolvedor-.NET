using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestibularAPI.infraestructure.model;

[Table("ProcessosSeletivos")]
public class ProcessoSeletivo : BaseEntity{

    [Column("Nome")]
    [Required]
    [StringLength(150)]
    public string Nome {get; set;} = "";
    
    [Column("DataDeInicio")]
    public DateTime DataDeInicio {get;set;}

    [Column("DataDeFim")]
    public DateTime DataDeFim {get; set;}

    public List<Inscricao> Incricoes {get; set;} = new List<Inscricao>();

}