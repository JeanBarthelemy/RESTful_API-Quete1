using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Restful_API_Quete_1
{
    public class Album
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public List<Photo> photos { get; set; }
    }
}
