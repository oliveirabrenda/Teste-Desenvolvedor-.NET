namespace VestibularAPI.Controllers.dto;

public class CandidatoDto : BaseDto{

    public string Nome {get; set;} = "";

    public string Email {get; set;} = "";
    
    public string Telefone {get; set;} = "";
    
    public string Cpf {get; set;} = "";

    public List<InscricaoDto> Incricoes {get; set;} = new List<InscricaoDto>();    
}