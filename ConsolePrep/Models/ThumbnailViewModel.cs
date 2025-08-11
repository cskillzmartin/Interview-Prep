using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace ContentPal.App.Models
{
    public class ThumbnailViewModel
    {
        [Display(Name = "Upload Thumbnail")]
        [Required(ErrorMessage = "Please select a file")]
        public IFormFile File { get; set; }

        [Display(Name = "Test Type")]
        [Required(ErrorMessage = "Please select a test type")]
        public string TestType { get; set; }

        [Display(Name = "Youtube Video Id")]
        [Required(ErrorMessage = "Please enter a thumbnail URL")]
        public string URL { get; set; }
    }

    public class Prediction
    {
        public double probability { get; set; }
        public string tagId { get; set; }
        public string tagName { get; set; }
    }

    public class PredicationRoot
    {
        public string id { get; set; }
        public string project { get; set; }
        public string iteration { get; set; }
        public DateTime created { get; set; }
        public string URL { get; set; }
        public List<Prediction> predictions { get; set; }
    }


}
