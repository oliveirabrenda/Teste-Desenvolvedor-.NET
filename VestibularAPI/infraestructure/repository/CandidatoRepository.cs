using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;

namespace VestibularAPI.infraestructure.repository;

public class CandidatoRepository : BaseRepository<Candidato>, ICandidatoRepository
{
    public CandidatoRepository(VestibularContext db) : base(db)
    {
    }
}