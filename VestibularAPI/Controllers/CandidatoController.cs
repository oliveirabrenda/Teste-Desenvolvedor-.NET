using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VestibularAPI.Controllers.dto;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.repository;

namespace VestibularAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CandidatoController : ControllerBase
{

    private readonly ICandidatoRepository _candidatoRepository;
    private readonly IMapper _mapper;

    public CandidatoController(ICandidatoRepository candidatoRepository, IMapper mapper)
    {
        _candidatoRepository = candidatoRepository;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetCandidatos")]
    public IEnumerable<CandidatoDto> GetAll()
    {
        return _mapper.Map<List<CandidatoDto>>(_candidatoRepository.FindAll());
    }

    [HttpGet("{id}")]
    public CandidatoDto GetById(Guid id)
    {
        return _mapper.Map<CandidatoDto>(_candidatoRepository.FindById(id));
    }

    [HttpPost(Name = "PostCandidato")]
    public CandidatoDto PostCandidato(CandidatoDto candidatoDto){
        
        Candidato candidato = _mapper.Map<Candidato>(candidatoDto);

        return _mapper.Map<CandidatoDto>(_candidatoRepository.Create(candidato));
    }

    [HttpPatch(Name = "PatchCandidato")]
    public CandidatoDto PatchCandidato(CandidatoDto candidatoDto){
        
        Candidato candidato = _mapper.Map<Candidato>(candidatoDto);

        return _mapper.Map<CandidatoDto>(_candidatoRepository.Update(candidato));
    }

    [HttpDelete("{id}")]
    public bool DeleteCandidato(Guid id){
        
        return _candidatoRepository.Delete(id);
    }
}
