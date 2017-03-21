using InterfaceTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityHelper;
namespace ValidationRepo
{
    public class Validations : IValidation<ITriangle>
    {
        public string Validate(int SideALength, int SideBLength, int SideCLength)
        {
            //check for any side is having invalid number or not
            if (Utility.CheckForNuLLOrEmpty(SideALength) ||
               Utility.CheckForNuLLOrEmpty(SideBLength) ||
                Utility.CheckForNuLLOrEmpty(SideCLength))

                return "Please enter all three sides!";

            //Check for any two sides total is less than the third side or not. 
            //if found then it is inequality theorem and triagle cannot be formed so throw error
            else if ((SideALength + SideBLength) < SideCLength || (SideALength + SideBLength) < SideCLength || (SideALength + SideBLength) < SideCLength)
            {
                return "Triangle cannot be formed! Any two sides total should be grater than the third side.";
            }
            else
            {
                return "";
            }
        }
    }
}
