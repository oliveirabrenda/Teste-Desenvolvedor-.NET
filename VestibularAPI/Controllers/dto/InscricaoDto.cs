namespace VestibularAPI.Controllers.dto;

public class InscricaoDto : BaseDto{
    
     public int NumeroDeInscricao { get; set; }
    public DateTime Data { get; set; }
    public StatusDto Status { get; set; }
    public Guid IdCandidato { get; set; }
    public Guid IdProcessoSeletivo { get; set; }
    public Guid IdCurso { get; set; }
}