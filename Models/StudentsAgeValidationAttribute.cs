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

            if (value != null)
            {
                try
                {
                    studendBirthday = Convert.ToDateTime(value);
                    int studentAge = Convert.ToInt32((DateTime.Now.Subtract(studendBirthday)).TotalDays/365);
                    if (studendBirthday != null && studentAge >= 40 || studendBirthday != null && studentAge <= 15)
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