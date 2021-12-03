using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum UserTypes
    {
        [Display(Name = "Admin")]
        type1 = 1,
        [Display(Name = "Yazilimci")]
        type2 = 2,
        [Display(Name = "Kullanici")]
        type3 = 3,
    }
}
