﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCCSE.Shared
{
    public class Tour
    {
        [Key]
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public int length { get; set; }
        public int spaces { get; set; }
        public decimal cost { get; set; }
    }
}
