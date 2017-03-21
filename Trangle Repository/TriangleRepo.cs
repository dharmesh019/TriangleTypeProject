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
        public string SideALength
        {
            get; set;
        }

        public string SideBLength
        {
            get; set;
        }

        public string SideCLength
        {
            get; set;
        }

        public TriangleRepo(IValidation<ITriangle> obj) 
        {
            validation = obj;
        }


        public string CalculateTriangleType(int SideA, int SideB, int SideC)
        {
            //Equilateral Triangle as all Sides are same 
            if (SideA == SideB && SideA == SideC)
            {
                return TriangleTypeEnum.Equilateral.ToString();
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC) // Any two sides are equal, it is called Isosceles triangle
            {
                return TriangleTypeEnum.Isosceles.ToString();
            }
            else // None of the sides are equal, It is called Scalene Triangle
            {
                return TriangleTypeEnum.Scalence.ToString();
            }
        }

        public string ValidateTriangleSideInputs()
        {
           return validation.Validate(this.SideALength.ToString(), this.SideBLength.ToString(),this.SideCLength.ToString());
        }

    }
}
