﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace telefonrehberi.Models
{
    public class departmanlar
    {
        [Key]
        public int id { get; set; }
        public string departmanad { get; set; }
    }
}
