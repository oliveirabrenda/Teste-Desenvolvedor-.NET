namespace VestibularAPI.Controllers.dto;

public class CursoDto : BaseDto{

     public string Nome { get; set; } = "";
     public string Descricao { get; set; } = "";
     public int VagasDisponiveis { get; set; }
     public List<Guid> InscricaoIds { get; set; } = new List<Guid>();
}