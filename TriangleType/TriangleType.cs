using InterfaceTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleType
{
    public class TriangleType : ITriangleType
    {
        public string GetTriangleType(ITriangle obj)
        {
            //Equilateral Triangle as all Sides are same 
            if (obj.SideALength == obj.SideBLength && obj.SideALength == obj.SideCLength)
            {
                return TriangleTypeEnum.Equilateral.ToString();
            }
            else if (obj.SideALength == obj.SideBLength || obj.SideALength == obj.SideCLength || obj.SideBLength == obj.SideCLength) // Any two sides are equal, it is called Isosceles triangle
            {
                return TriangleTypeEnum.Isosceles.ToString();
            }
            else // None of the sides are equal, It is called Scalene Triangle
            {
                return TriangleTypeEnum.Scalence.ToString();
            }

        }
    }
}
