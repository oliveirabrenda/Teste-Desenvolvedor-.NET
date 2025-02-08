using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;

namespace VestibularAPI.infraestructure.repository;

public class CursoRepository : BaseRepository<Curso>, ICursoRepository
{
    public CursoRepository(VestibularContext db) : base(db)
    {
    }
}