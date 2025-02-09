using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VestibularAPI.Controllers.dto;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.repository;

namespace VestibularAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class InscricaoController : ControllerBase
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly ICandidatoRepository _candidatoRepository;
    private readonly IMapper _mapper;

    public InscricaoController(IInscricaoRepository inscricaoRepository, IMapper mapper, ICandidatoRepository candidatoRepository)
    {
        _inscricaoRepository = inscricaoRepository;
        _mapper = mapper;
        _candidatoRepository = candidatoRepository;
    }

    [HttpGet(Name = "GetInscricoes")]
    public IEnumerable<InscricaoDto> GetAll()
    {
        return _mapper.Map<List<InscricaoDto>>(_inscricaoRepository.FindAll());
    }

    [HttpGet("{id}")]
    public InscricaoDto GetById(Guid id)
    {
        return _mapper.Map<InscricaoDto>(_inscricaoRepository.FindById(id));
    }

    [HttpPost(Name = "PostInscricao")]
    public InscricaoDto PostInscricao(InscricaoDto inscricaoDto)
    {
        Inscricao inscricao = _mapper.Map<Inscricao>(inscricaoDto);
        return _mapper.Map<InscricaoDto>(_inscricaoRepository.Create(inscricao));
    }

    [HttpPatch(Name = "PatchInscricao")]
    public InscricaoDto PatchInscricao(InscricaoDto inscricaoDto)
    {
        Inscricao inscricao = _mapper.Map<Inscricao>(inscricaoDto);
        return _mapper.Map<InscricaoDto>(_inscricaoRepository.Update(inscricao));
    }

    [HttpDelete("{id}")]
    public bool DeleteInscricao(Guid id)
    {
        return _inscricaoRepository.Delete(id);
    }

    //GPT QUE DEU ISSO

    //  Buscar inscrições por CPF (agora retornando DTOs)
    [HttpGet("cpf/{cpf}")]
    public IActionResult GetByCpf(string cpf)
    {

        var canditato = _candidatoRepository.FindAll().FirstOrDefault(x => x.Cpf == cpf);
        
        if (canditato == null)
        {
            return NotFound("Nenhuma inscrição encontrada para esse CPF.");
        }

        var inscricoes = _inscricaoRepository.FindAll().ToList().Where(x => x.IdCandidato.Equals(canditato.Id));

        if (inscricoes == null || inscricoes.Count() == 0)
        {
            return NotFound("Nenhuma inscrição encontrada para esse CPF.");
        }

        return Ok(_mapper.Map<List<InscricaoDto>>(inscricoes));
    }

    //  Buscar inscrições por Curso (Oferta)
    [HttpGet("curso/{cursoId}")]
    public IActionResult GetByCurso(Guid cursoId)
    {
        var inscricoes = _inscricaoRepository.FindAll().Where(x => x.IdCurso == cursoId).ToList();

        if (inscricoes == null || inscricoes.Count == 0)
        {
            return NotFound("Nenhuma inscrição encontrada para esse curso.");
        }
        return Ok(_mapper.Map<List<InscricaoDto>>(inscricoes));
    }
    
}


 