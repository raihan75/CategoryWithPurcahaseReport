﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileError.Model.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ReorderLevel { get; set; }
        public string Description { get; set; }

    }
}
