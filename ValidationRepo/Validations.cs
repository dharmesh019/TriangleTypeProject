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
        public string Validate(string SideALength, string SideBLength, string SideCLength)
        {
            
            //Check for numeric value 
            if(Utility.CheckForValidInteger(SideALength.ToString()) <= 0 || Utility.CheckForValidInteger(SideBLength.ToString()) <=0 || Utility.CheckForValidInteger(SideCLength.ToString())<=0)
            {
                
                return "All three sides must be numeric integer types having value greater than 0!";
            }
            //Check for any two sides total is less than the third side or not. 
            var IntSideALength = Convert.ToInt16(SideALength);
            var IntSideBLength = Convert.ToInt16(SideBLength);
            var IntSideCLength = Convert.ToInt16(SideCLength);

            //if found then it is inequality theorem and triagle cannot be formed so throw error
            if ((IntSideALength + IntSideBLength) < IntSideCLength || (IntSideALength + IntSideBLength) < IntSideCLength || (IntSideALength + IntSideBLength) < IntSideCLength)
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
