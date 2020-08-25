using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessRuleEngine.DAL.Entities
{
    [Table("agentCommission")]
    public class AgentCommision
    {
        [Column("agentCommissionId")]
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Agent))]
        public Guid AgentId { get; set; }

        [Column("commissionAmount")]
        public double CommissionAmount { get; set; }


        [Column("dateTimeStamp")]
        public DateTime DateTimeStamp { get; set; }
    }
}
