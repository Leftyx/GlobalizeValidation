using GlobalizeValidation.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalizeValidation.Models
{
    public class PersonViewModel : _LayoutViewModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage="Field {0} required.")]
        public string Name { get; set; }

        [DisplayName("Deposit")]
        [Range(typeof(decimal), "0", "9999.99", ErrorMessage = "{0} decimal number between {1} and {2}.")]
        public decimal? Deposit { get; set; }
    }
}