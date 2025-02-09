using Microsoft.EntityFrameworkCore;
using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;

namespace VestibularAPI.infraestructure.repository;


public class InscricaoRepository : BaseRepository<Inscricao>, IInscricaoRepository
{

    public InscricaoRepository(VestibularContext db) : base(db)
    {
    }

}