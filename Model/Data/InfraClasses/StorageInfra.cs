﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LykovProject.Model.Data.InfraClasses
{
    public class StorageInfra : AbstractInfrastucture
    {
        public StorageInfra(string name, Sprite sprite) : base(name, InfraType.LAND, sprite)
        {
            
        }

        // логика этого здания
    }
}