using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_WebPage.Models
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
