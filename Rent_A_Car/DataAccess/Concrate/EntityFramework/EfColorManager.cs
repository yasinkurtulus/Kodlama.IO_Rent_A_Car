﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Entities.Concrate.Color;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfColorManager:EfEntityRepositoryBase<Color,RentCarContext>,IColorDal
    {

    }
}
