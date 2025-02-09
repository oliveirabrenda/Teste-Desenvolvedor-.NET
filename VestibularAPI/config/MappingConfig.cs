using System.Diagnostics;
using AutoMapper;
using VestibularAPI.Controllers.dto;
using VestibularAPI.infraestructure.model;

namespace VestibularAPI.config;

public class MappingConfig{

    public static MapperConfiguration RegisterMaps(){

        var mappingConfiguration = new MapperConfiguration(config => {

            config.CreateMap<Candidato, CandidatoDto>().ReverseMap();
            config.CreateMap<Curso, CursoDto>().ReverseMap();
            config.CreateMap<Inscricao, InscricaoDto>().ReverseMap();
            config.CreateMap<ProcessoSeletivo, ProcessoSeletivoDto>().ReverseMap();
        });

        return mappingConfiguration;
    }
}