using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessRuleEngine.DAL.Entities
{
    [Table("agent")]
    public class Agent
    {
        [Column("agentId")]
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Agent Name is mandatory")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
    }
}
