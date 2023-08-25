﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class TireDto
    {
        public int Id { get; set; }
        public string? Photo { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public string? Supplier { get; set; }
        public decimal? Price { get; set; }
        public int? Profile { get; set; }
        public int? Width { get; set; }
        public int? Ring { get; set; }
    }
}
