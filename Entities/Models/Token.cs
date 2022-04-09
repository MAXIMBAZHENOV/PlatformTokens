using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Token
    {
        [Column("TokenId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Token name is a required field.")]
        [MaxLength(10,ErrorMessage ="Maximum  length for the name is 10 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Price is a required field")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "MarketCap is a required field")]
        public decimal MarketCap { get; set; }

        [ForeignKey(nameof(Platform))]
        public Guid PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
