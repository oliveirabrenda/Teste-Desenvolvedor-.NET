using Microsoft.EntityFrameworkCore;

namespace VestibularAPI.infraestructure.model.context;

public class VestibularContext : DbContext{
    
        public VestibularContext() { }

        public VestibularContext(DbContextOptions<VestibularContext> options) : base(options) { }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<ProcessoSeletivo> ProcessoSeletivos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                
                base.OnModelCreating(modelBuilder);
        }
}