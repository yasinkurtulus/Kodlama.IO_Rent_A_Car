﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Customer:IEntity
    {
       
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
