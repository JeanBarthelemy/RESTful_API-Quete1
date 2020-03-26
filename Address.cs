using System;
using System.Collections.Generic;
using System.Text;

namespace Restful_API_Quete_1
{
    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }

    }
}
