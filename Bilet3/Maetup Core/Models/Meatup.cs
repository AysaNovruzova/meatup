using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maetup_Core.Models
{
    public class Meatup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
      
        public string Title { get; set; } = null!;
        [Required]
        
        public string SubTitle { get; set; } = null!;
       
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile? FotoFile { get; set; }
       
    }
}
