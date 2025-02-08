using VestibularAPI.infraestructure.model;
using VestibularAPI.infraestructure.model.context;

namespace VestibularAPI.infraestructure.repository;

public class ProcessoSeletivoRepository : BaseRepository<ProcessoSeletivo>, IProcessoSeletivoRepository
{
    public ProcessoSeletivoRepository(VestibularContext db) : base(db)
    {
    }
}