using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities.DTO
{
    public class FilterInformation
    {
        public UserDTO User { get; set; }
        public List<ShiftsInf> Shifts { get; set; }
    }
}
