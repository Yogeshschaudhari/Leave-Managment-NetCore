using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment_NetCore.Data
{
    public class LeaveType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string  Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
