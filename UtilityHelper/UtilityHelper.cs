using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityHelper
{
    public static class Utility
    {
        public static bool CheckForNuLLOrEmpty(int? ValueToCheck)
        {
            if (ValueToCheck.HasValue && ValueToCheck.Value > 0)
                return true;
            else
                return false;
        }

        public static bool CheckForTriangleSideValidation(params int[] intValues)
        {

            return false;
        }
    }
}
