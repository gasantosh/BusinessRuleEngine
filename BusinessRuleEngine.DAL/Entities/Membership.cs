using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessRuleEngine.DAL.Entities
{
    [Table("membership")]
    public class Membership
    {
        [Column("membershipId")]
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Member Name is mandatory")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Column("isActive")]
        public bool IsActive { get; set; }

        [Column("dateTimeStamp")]
        public DateTime DateTimeStamp { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}
