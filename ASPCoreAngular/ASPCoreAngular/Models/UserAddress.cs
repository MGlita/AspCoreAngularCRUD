using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAngular.Models
{
    public class UserAddress
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(6)")]
        public string ZipCode { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string Street { get; set; }
    }
}
