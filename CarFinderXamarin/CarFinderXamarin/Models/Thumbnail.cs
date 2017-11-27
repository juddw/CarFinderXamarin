using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinderXamarin.Models
{
    public class Thumbnail
    {
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
