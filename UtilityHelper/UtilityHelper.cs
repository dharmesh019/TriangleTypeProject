using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityHelper
{
    public static class Utility
    {
        private static bool CheckForNumberic(string ValueToCheck)
        {
            try
            {
                var res = 0;
                if (int.TryParse(ValueToCheck, out res))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        //This function takes string and check for valid integer and return flags accordingly
        public static int CheckForValidInteger(string ValueToCheck)
        {
            if (CheckForNumberic(ValueToCheck))
            {
                if (Convert.ToInt16(ValueToCheck) > 0)
                    return 1;
                else
                    return -2; // Value must be greater than 0
            }
            else
                return -1; // InValid Integer value 
        }

       
    }
}
