using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_strength
{
    class Password
    {
        int  uppercase = 0;
        int lowercase = 0;
        int digits =0;
        int specialchar=0;
        public string passwordcheck(string passwords)
        {
            string strength = string.Empty;
            foreach (char i in passwords.ToCharArray())
            {
                if (char.IsUpper(i))
                {
                    uppercase = 1;
                }
                else if (char.IsLower(i))
                {
                    lowercase = 1;
                }
                else if (char.IsDigit(i))
                {
                    digits = 1;
                }
                else
                {
                    specialchar = 1;
                }
            }
            if (uppercase == 1 && lowercase == 1 && digits == 1 && specialchar == 1 && passwords.Length > 8)
            {
                strength = "Very Strong";
            }
            else if (uppercase == 1 && lowercase == 1 && digits == 1 && passwords.Length == 8)
            {
                strength = "Strong";
            }
            else if (uppercase == 1 && lowercase == 1 && digits == 1 && passwords.Length == 8)
            {
                strength = "Average";
            }
            else if( lowercase == 1 && digits == 1 && passwords.Length == 8)
            {
                strength = " Weak";
            }
            else if (passwords.Length < 8)
            {
                strength = "Very Weak";
            }
            return strength;
        }
    }
}
