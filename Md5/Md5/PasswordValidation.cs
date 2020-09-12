using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Md5
{
    class PasswordValidation
    {
        public Boolean isValidPasswordPattern(string password) { 
        
            string regEx = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            return Regex.IsMatch(password, regEx);
        }
        
    }
}
