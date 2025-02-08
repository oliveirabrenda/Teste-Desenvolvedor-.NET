namespace VestibularAPI.Controllers.dto;

public class ProcessoSeletivoDto : BaseDto{
    
        public string Nome { get; set; } = "";
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeFim { get; set; }
        public List<InscricaoDto> Incricoes {get; set;} = new List<InscricaoDto>();    


}