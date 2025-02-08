using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VestibularAPI.Controllers.dto;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.repository;

namespace VestibularAPI.Controllers;

[ApiController]
[Route("[controller]")]


public class ProcessoSeletivoController : ControllerBase
{
    private readonly IProcessoSeletivoRepository _processoSeletivoRepository;
    private readonly IMapper _mapper;

    public ProcessoSeletivoController(IProcessoSeletivoRepository processoSeletivoRepository, IMapper mapper)
    {
        _processoSeletivoRepository = processoSeletivoRepository;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetProcessosSeletivos")]
    public IEnumerable<ProcessoSeletivoDto> GetAll()
    {
        return _mapper.Map<List<ProcessoSeletivoDto>>(_processoSeletivoRepository.FindAll());
    }

    [HttpGet("{id}")]
    public ProcessoSeletivoDto GetById(Guid id)
    {
        return _mapper.Map<ProcessoSeletivoDto>(_processoSeletivoRepository.FindById(id));
    }

    [HttpPost(Name = "PostProcessoSeletivo")]
    public ProcessoSeletivoDto PostProcessoSeletivo(ProcessoSeletivoDto processoSeletivoDto)
    {
        ProcessoSeletivo processoSeletivo = _mapper.Map<ProcessoSeletivo>(processoSeletivoDto);
        return _mapper.Map<ProcessoSeletivoDto>(_processoSeletivoRepository.Create(processoSeletivo));
    }

    [HttpPatch(Name = "PatchProcessoSeletivo")]
    public ProcessoSeletivoDto PatchProcessoSeletivo(ProcessoSeletivoDto processoSeletivoDto)
    {
        ProcessoSeletivo processoSeletivo = _mapper.Map<ProcessoSeletivo>(processoSeletivoDto);
        return _mapper.Map<ProcessoSeletivoDto>(_processoSeletivoRepository.Update(processoSeletivo));
    }

    [HttpDelete("{id}")]
    public bool DeleteProcessoSeletivo(Guid id)
    {
        return _processoSeletivoRepository.Delete(id);
    }
}