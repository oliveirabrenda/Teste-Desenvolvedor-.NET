using VestibularAPI.infraestructure.model;

namespace VestibularAPI.infraestructure.repository;

public interface IInscricaoRepository : IBaseRepository<Inscricao>{
        // GPT QUE DEU

    List<Inscricao> GetByCpf(string cpf);
    List<Inscricao> GetByCurso(Guid cursoId);
}