using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ValidationAttrApp.Models
{
    public class StudentsAgeValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime studendBirthday;
            Debug.WriteLine("Hello out");
            Trace.Write("Trace Out");
            if (value != null)
            {
                try
                {
                    studendBirthday = Convert.ToDateTime(value);
                    Debug.WriteLine("Hello in");
                    if (studendBirthday != null && (DateTime.Now.Subtract(studendBirthday)).TotalDays >= 40 || 
                        studendBirthday != null && (DateTime.Now.Subtract(studendBirthday)).TotalDays <= 15)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}