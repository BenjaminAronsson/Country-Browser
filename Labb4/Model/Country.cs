using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Labb4
{
    public class Country
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Currency { get; set; }
        public int Population { get; set; }
        public string PictureUrl { get; set; } = "sweden.png";

        public Country()
        {
        }

    }
}