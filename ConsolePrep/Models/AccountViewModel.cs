using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ContentPal.App.Models
{
    public class YTDataUploadModel
    {
        [Display(Name = "Upload YT Analytics Data of 28 Days or More. (.csv)")]
        [Required(ErrorMessage = "Please select a file")]
        public IFormFile File { get; set; }

        [Display(Name = "Your Creator Content Companion License Key.")]
        public string Key { get; set; }

        public string UserID { get; set; }
    }
}
