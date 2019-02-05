using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TSystems.MMS.Bewerbungsgenerator.Models
{
    public class Form
    {
        public int Id { get; set; }
        [Display(Name = "First name")]
        [Required]
        public string FristName { get; set; }
        [Display(Name = "Last name")]
        [Required]
        public string LastName { get; set; }
        [NotMapped]        
        public string Name { get => $"{FristName} {LastName}"; }

        [Phone]
        [Required]
        [Display(ShortName = "Phone")]
        public string Telephone { get; set; }
        [Required]
        [Display(ShortName = "Org")]
        public string Organisation { get; set; }

        //TODO: this can be more general if we put this stuff in seperate fields
        #region Questions
        [Display(Name="What is your motivation for this job?", ShortName = "Motivation")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Motivation { get; set; }

        [Display(Name = "Did you study?", ShortName = "Study")]
        [Required]
        public bool Study { get; set; }

        [Display(Name = "Why are your the right one for us?", ShortName = "The Right")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string TheRight { get; set; }
        #endregion

        //TODO: This can be more general if we put this stuff in seperate stage classes
        #region Stages
        [Display(Name="First invitation")]
        [DataType(DataType.Date)]
        public DateTime FirstInvitation { get; set; }

        public bool Accepted { get; set; }
        #endregion
    }
}
