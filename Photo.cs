using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Restful_API_Quete_1
{
    public class Photo
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
        public List<Comment> comments { get; set; }
    }
}
