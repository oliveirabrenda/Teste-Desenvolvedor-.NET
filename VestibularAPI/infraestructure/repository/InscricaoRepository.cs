using Microsoft.EntityFrameworkCore;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;

namespace VestibularAPI.infraestructure.repository;

    // GPT QUE DEU

public class InscricaoRepository : BaseRepository<Inscricao>, IInscricaoRepository
{
    private readonly VestibularContext _context;

    public InscricaoRepository(VestibularContext context) : base(context)
    {
        _context = context;
    }

    // Buscar inscrições por CPF
    public List<Inscricao> GetByCpf(string cpf)
    {
        return _context.Inscricoes
            .Include(i => i.Candidato) // Inclui os dados do candidato
            .Where(i => i.Candidato.Cpf == cpf) // Filtra pelo CPF
            .ToList();
    }

    // Buscar inscrições por Curso (Oferta)
    public List<Inscricao> GetByCurso(Guid cursoId)
    {
        return _context.Inscricoes
            .Include(i => i.Curso) // Inclui os dados do curso
            .Where(i => i.IdCurso == cursoId) // Filtra pelo curso
            .ToList();
    }
}
