using System;
using System.ComponentModel.DataAnnotations;

namespace RobsWebsiteV2.Models
{
    public class PowerModel
    {
        [Required]
        [Range(0,30)]
        public  double PowerFront { get; set; }

        [Required]
        [Range(-30,0)]
        public  double PowerBack { get; set; }

        [Required]
        public  double Result { get; set; }

        
    }
}
