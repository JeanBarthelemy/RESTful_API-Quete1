using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Restful_API_Quete_1
{
    public class Comment
    {
        public int id { get; set; }
        public string body { get; set; }
        public int postId { get; set; }
    }
}
