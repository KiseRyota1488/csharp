using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public interface IPart
    {
        string GetPart();
        string GetMaterial(Material mat);
    }
}
