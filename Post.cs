﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Restful_API_Quete_1
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
