using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsStd
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// Return current age based on date of birth
        /// </summary>
        /// <param name="dob"></param>
        /// <returns></returns>
        public static int Age(this DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
