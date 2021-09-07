using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment_NetCore.Models
{
    public class DetailsLeaveTypeVM 
    {
        public int ID { get; set; }       
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        public string Name { get; set; }        
    }
}
