using FactoryTriangleNameSpace;
using InterfaceTriangle;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trangle_Repository;
using ValidationRepo;
namespace TriangleUnitTestProject
{
    [TestFixture]
   public class TriangleUnitTest
    {

      
        [Test, TestCaseSource("TriangleTestCases")]
        public string TestTriangleSideValue(string SideALength, string SideBLength, string SideCLength)
        {
           Validations ObjValidation = new Validations();
           
         return   ObjValidation.Validate(SideALength, SideBLength, SideCLength);


        }

        public static IEnumerable TriangleTestCases
        {

            get
            {
                // This arraylist can be provided from database
                ArrayList objTestCaseData = new ArrayList();
                //negative value not allowed
                objTestCaseData.Add(new TestCaseData("-1","2","4").Returns("All three sides must be numeric integer types having value greater than 0!"));
                //Empty values not allowed
                objTestCaseData.Add(new TestCaseData("","", "20").Returns("All three sides must be numeric integer types having value greater than 0!"));
                //Value must be greater than 0
                objTestCaseData.Add(new TestCaseData("2","0", "30").Returns("All three sides must be numeric integer types having value greater than 0!"));
                //value cannot be string
                objTestCaseData.Add(new TestCaseData("e","3", "t").Returns("All three sides must be numeric integer types having value greater than 0!"));
                //summation of two sides must be greater than third side
                objTestCaseData.Add(new TestCaseData("2", "3", "6").Returns("Triangle cannot be formed! Any two sides total should be grater than the third side."));
                //Successful Side entry
                objTestCaseData.Add(new TestCaseData("2", "3", "4").Returns(""));
                //Side values must be integer number not a float or decimal
                objTestCaseData.Add(new TestCaseData("2.3", "3", "4").Returns("All three sides must be numeric integer types having value greater than 0!"));

              
                // This arraylist can be provided from database
                foreach (TestCaseData obj in objTestCaseData)
                {
                    yield return obj;
                }


            }

        }
        public static IEnumerable TriangleTestCasesForTriangleTypes
        {

            get
            {
                // This arraylist can be provided from database
                ArrayList objTestCaseData = new ArrayList();
                objTestCaseData.Add(new TestCaseData(1, 1, 1).Returns("Equilateral"));
                objTestCaseData.Add(new TestCaseData(3, 3, 1).Returns("Isosceles"));
                objTestCaseData.Add(new TestCaseData(2,4, 3).Returns("Scalence"));


                // This arraylist can be provided from database
                foreach (TestCaseData obj in objTestCaseData)
                {
                    yield return obj;
                }


            }

        }
        [Test, TestCaseSource("TriangleTestCasesForTriangleTypes")]
        public string TestCalculateTriangleTypes(int SideALength, int SideBLength, int SideCLength)
        {
            var TriangleObj = FactoryTriangle.Create();

            return TriangleObj.CalculateTriangleType(SideALength, SideBLength, SideCLength);


        }
    }
}
