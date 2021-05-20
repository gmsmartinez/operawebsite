using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperaWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }


        [CheckValidYear]

        public int Year { get; set; }

        [Required]
        public string Compositor { get; set; }
    }
}