﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCCSE.Shared
{
    public class PaymentItem
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; } = "";
        public decimal cost { get; set; } = 0;
        public int quantity { get; set; } = 1;
    }
}
