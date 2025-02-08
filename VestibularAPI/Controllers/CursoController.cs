using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VestibularAPI.Controllers.dto;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.repository;

namespace VestibularAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CursoController : ControllerBase
{

    private readonly ICursoRepository _cursoRepository;
    private readonly IMapper _mapper;

    public CursoController(ICursoRepository CursoRepository, IMapper mapper)
    {
        _cursoRepository = CursoRepository;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetCursos")]
    public IEnumerable<CursoDto> GetAll()
    {
        return _mapper.Map<List<CursoDto>>(_cursoRepository.FindAll());
    }

    [HttpGet("{id}")]
    public CursoDto GetById(Guid id)
    {
        return _mapper.Map<CursoDto>(_cursoRepository.FindById(id));
    }

    [HttpPost(Name = "PostCurso")]
    public CursoDto PostCurso(CursoDto cursoDto){
        
        Curso curso = _mapper.Map<Curso>(cursoDto);

        return _mapper.Map<CursoDto>(_cursoRepository.Create(curso));
    }

    [HttpPatch(Name = "PatchCurso")]
    public CursoDto PatchCurso(CursoDto cursoDto){
        
        Curso curso = _mapper.Map<Curso>(cursoDto);

        return _mapper.Map<CursoDto>(_cursoRepository.Update(curso));
    }

    [HttpDelete("{id}")]
    public bool DeleteCurso(Guid id){
        
        return _cursoRepository.Delete(id);
    }
}
