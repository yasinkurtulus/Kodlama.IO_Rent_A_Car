﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Brand:IEntities
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } 
    }
}
