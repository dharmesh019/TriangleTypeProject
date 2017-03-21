using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTriangle
{
    //this Enum indicates the various Triangle types can be formed using three sides 
    public enum TriangleTypeEnum
    {
        Scalence=1,
        Isosceles=2,
        Equilateral=3
    }
    public interface ITriangle
    {
        
        string SideALength { get; set; }
        string SideBLength { get; set; }
        string SideCLength { get; set; }
        string CalculateTriangleType(int SideA, int SideB, int SideC);

        string ValidateTriangleSideInputs();
    }


    public interface ITriangleType
    {
        string GetTriangleType(ITriangle obj);
    }

    public interface IValidation<AnyType>
    {
        //string variable is used here to validate any input including characters and plugin validation class object when needed for validating the triangle side length
        string Validate(string SideALength, string SideBLength, string SideCLength);
    }


}
