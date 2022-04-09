using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Platform
    {
        [Column("PlatformID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Platform name is a required field.")]
        [MaxLength(60,ErrorMessage ="Maximum length for the Name is 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type of consensus is a required field")]
        public string ConsensusAlgorithm { get; set; }

        public ICollection<Token> Tokens { get; set; }

        
    }
}
