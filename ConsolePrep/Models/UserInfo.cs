using System;
using System.Collections.Generic;

namespace ContentPal.App.Models
{
    public class UserDataBase
    {
        public string id { get; set; }
        public string UserId { get; set; }
        public string FileName { get; set; }
        public string URL { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public class UserData : UserDataBase
    {
      
    }
    public class Thumbnail : UserDataBase
    {
        public Prediction[] Prediction { get; set; }
    }

    public class Caption : UserDataBase
    {

    }
    public class Translation : UserDataBase
    {
        public string CaptionId { get; set; }
    }
    public class Predictions
    {
        public string Name { get; set; }
        public string Probability { get; set; }
    }

    #region custom vision models
    public class Analysis : UserDataBase
    {        
        public Predictions[] categories { get; set; }
        public Adult adult { get; set; }
        public Color color { get; set; }
        public ImageType imageType { get; set; }
        public Tags[] tags { get; set; }
        public Description description { get; set; }
        public Faces[] faces { get; set; }
        public Objects[] objects { get; set; }
        public Brand[] brands { get; set; }
        public string requestId { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Faces
    {
        public int age { get; set; }
        public string gender { get; set; }
        public FaceRectangle faceRectangle { get; set; }
    }
    public class Description
    {
        public string[] tags { get; set; }
        public Captions[] captions { get; set; }
    }
    public class Adult
    {
        public bool isAdultContent { get; set; }
        public bool isRacyContent { get; set; }
        public bool isGoryContent { get; set; }
        public float adultScore { get; set; }
        public float racyScore { get; set; }
        public float goryScore { get; set; }

    }
    public class Color
    {
        public string dominantColorForeground { get; set; }
        public string dominantColorBackground { get; set; }
        public string[] dominantColors { get; set; }
        public string accentColor { get; set; }
        public bool isBwImg { get; set; }
        public bool isBWImg { get; set; }
    }
    public class Brand
    {
        public string name { get; set; }
        public string confidence { get; set; }
        public Rectangle rectangle { get; set; }
    }
    public class ImageType
    {
        public string clipArtType { get; set; }
        public string lineDrawingType { get; set; }
    }
    public class Captions
    {
        public string text { get; set; }
        public float confidence { get; set; }
    }
    public class Objects
    {
        public Rectangle rectangle { get; set; }
        public string _object { get; set; }
        public float confidence { get; set; }
    }
    public class FaceRectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    public class Rectangle
    {
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }
    public class Metadata
    {
        public int height { get; set; }
        public int width { get; set; }
        public string format { get; set; }
    }
    public class Tags
    {
        public string name { get; set; }
        public float confidence { get; set; }
    }
    //need faces, brands, 
    #endregion
}
