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

        [TestCase(1,2)]
        [Test]
        public int ADD(int a, int b)
        {
            return 3;
        }

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
                objTestCaseData.Add(new TestCaseData(-1,2,4).Returns("All three sides must be numeric integer types!"));
                objTestCaseData.Add(new TestCaseData(null,null, 20).Returns("All three sides must be numeric integer types!"));
                objTestCaseData.Add(new TestCaseData(2,0, 30).Returns(900));
                objTestCaseData.Add(new TestCaseData("e",3, "t").Returns("All three sides must be numeric integer types!"));
                // This arraylist can be provided from database
                foreach (TestCaseData obj in objTestCaseData)
                {
                    yield return obj;
                }


            }

        }
    }
}
