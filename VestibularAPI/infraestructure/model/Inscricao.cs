using System.ComponentModel.DataAnnotations.Schema;
using VestibularAPI.infraestructure.model.enums;

namespace VestibularAPI.infraestructure.model;

public class Inscricao : BaseEntity{

    [Column("NumeroDeInscricao")]
    public int NumeroDeInscricao { get; set; }

    [Column("Data")]
    public DateTime Data { get; set; }

    [Column("Status")]
    public Status Status { get; set; }

    [Column("IdCandidato")]
    [ForeignKey("Candidato")]
    public Guid IdCandidato { get; set; }

    public Candidato? Candidato { get; set; } = null;

    [Column("IdProcessoSeletivo")]
    [ForeignKey("ProcessoSeletivo")]
    public Guid IdProcessoSeletivo { get; set; }
    
    public ProcessoSeletivo? ProcessoSeletivo { get; set; } = null;

    [Column("IdCurso")]
    [ForeignKey("Curso")]
    public Guid IdCurso { get; set; }
    
    public Curso? Curso { get; set; } = null;
}