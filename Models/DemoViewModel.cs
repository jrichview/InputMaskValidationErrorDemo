using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InputMaskValidationErrorDemo.Models
{
    public class DemoViewModel
    {
        [Display(Name = "Search for records created from:")]
        public DateTime? FromDate { get; set; }
        [Display(Name = "To:")]
        public DateTime? ToDate { get; set; }
    }
}