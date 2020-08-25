using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BusinessRuleEngine.DAL.Entities
{
    [Table("library")]
    public class Library
    {
        [Column("libraryId")]
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Library item Name is mandatory")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Column("isVideo")]
        public bool IsVideo { get; set; }

        [Column("dateTimeStamp")]
        public DateTime DateTimeStamp { get; set; }

        [Column("videoType")]
        [AllowNull]
        public string Type { get; set; }

        [Column("value")]
        public double Value { get; set; }
    }
}
