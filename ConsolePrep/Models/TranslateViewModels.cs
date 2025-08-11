using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Web.Mvc;

namespace ContentPal.App.Models
{
    public class TranslateBase{

        [Display(Name = "Languages")]
        public IEnumerable<SelectListItem> Languages { get; set; }

        public string DefaultLang { get; set; }

        [Display(Name = "Source Language")]
        public string FromLanguage { get; set; }

        [Display(Name = "Target Language")]
        [Required(ErrorMessage = "Please select a language (ctrl + click to select multiple)")]
        public string[] ToLanguages { get; set; }
    }

    public class LoadTranslateView : TranslateBase{
        [Display(Name = "Caption File")]
        [Required(ErrorMessage = "Please select a file")]
        public IFormFile File { get; set; }
    }    
}