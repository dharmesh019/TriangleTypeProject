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
        public void Validate(ITriangle obj)
        {
            //check for any side is having invalid number or not
            if (Utility.CheckForNuLLOrEmpty(obj.SideALength) ||
               Utility.CheckForNuLLOrEmpty(obj.SideBLength) ||
                Utility.CheckForNuLLOrEmpty(obj.SideCLength))
                throw new Exception("Please enter all three sides!");

            //Check for any two sides total is less than the third side or not. 
            //if found then it is inequality theorem and triagle cannot be formed so throw error
            if ((obj.SideALength + obj.SideBLength) < obj.SideCLength || (obj.SideALength + obj.SideBLength) < obj.SideCLength || (obj.SideALength + obj.SideBLength) < obj.SideCLength)
            {
                throw new Exception("Triangle cannot be formed! Any two sides total should be grater than the third side.");
            }
        }
    }
}
