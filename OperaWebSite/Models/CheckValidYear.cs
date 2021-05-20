using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperaWebSite.Models
{
    public class CheckValidYear:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int year = Convert.ToInt32(value);
            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}