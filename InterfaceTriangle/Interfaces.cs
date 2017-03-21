using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTriangle
{

    public enum TriangleTypeEnum
    {
        Scalence=1,
        Isosceles=2,
        Equilateral=3
    }
    public interface ITriangle
    {
        int SideALength { get; set; }
        int SideBLength { get; set; }
        int SideCLength { get; set; }
        string CalculateTriangleType(int SideA, int SideB, int SideC);

        string ValidateTriangleSideInputs();
    }


    public interface ITriangleType
    {
        string GetTriangleType(ITriangle obj);
    }

    public interface IValidation<AnyType>
    {
        string Validate(string SideALength, string SideBLength, string SideCLength);
    }


}
