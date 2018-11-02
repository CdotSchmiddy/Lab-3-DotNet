namespace DotNetMidtermA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        public int FlightId { get; set; }

        [Display(Name = "Type")]
        public int FlightTypeId { get; set; }

        [Display(Name = "Province")]
        public int ProvinceId { get; set; }

        [Display(Name = "Extra Bag")]
        public bool ExtraBag { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public virtual FlightType FlightType { get; set; }

        public virtual Province Province { get; set; }
    }
}
