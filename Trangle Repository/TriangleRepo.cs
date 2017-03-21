using InterfaceTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trangle_Repository
{
    public class TriangleRepo : ITriangle
    {
        private IValidation<ITriangle> validation = null;
        public int SideALength
        {
            get; set;
        }

        public int SideBLength
        {
            get; set;
        }

        public int SideCLength
        {
            get; set;
        }

        

      public string CalculateTriangleType(int SideA, int SideB, int SideC)
        {
            return "";
        }

        public string ValidateTriangleSideInputs()
        {
           return validation.Validate(this.SideALength, this.SideBLength,this.SideCLength);
        }

    }
}
