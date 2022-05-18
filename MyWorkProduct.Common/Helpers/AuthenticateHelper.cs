using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Common.Helpers
{
    public static class AuthenticateHelper
    {
        public static bool VerifyHashedString(string hashedValue, string userEnteredValue)
        {
            bool flag = false;
            flag = BCrypt.Net.BCrypt.Verify(userEnteredValue + "^M8~YY", hashedValue);
            return flag;
        }
    }
}
