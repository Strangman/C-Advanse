using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Models.Repository
{
    public interface IDLCRepository
    {
        List<DLC> GetDLCs();
    }
}
