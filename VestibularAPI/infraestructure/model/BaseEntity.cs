using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestibularAPI.infraestructure.model;

public abstract class BaseEntity{

    [Key]
    [Column("Id")]
    public Guid Id {get; set;}

    public BaseEntity(){
        
        Id = Guid.NewGuid();
    }
}
