﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public class Basement : IPart
    {
        public string GetPart()
        {
            return $"is working on {GetType().Name.ToLower()}";
        }
        public string GetMaterial(Material mat)
        {
            return $" | brick";
        }
    }
}
