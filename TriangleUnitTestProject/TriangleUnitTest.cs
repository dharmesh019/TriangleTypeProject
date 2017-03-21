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
        public void TestTriangleSideValue(int SideALength, int SideBLength, int SideCLength)
        {
           Validations ObjValidation = new Validations();
           
            ObjValidation.Validate(SideALength, SideBLength, SideCLength);


        }

        public static IEnumerable TriangleTestCases
        {

            get
            {
                // This arraylist can be provided from database
                ArrayList objTestCaseData = new ArrayList();
                objTestCaseData.Add(new TestCaseData(-1,2,4).Returns(100));
                objTestCaseData.Add(new TestCaseData(null,null, 20).Returns(400));
                objTestCaseData.Add(new TestCaseData(2,0, 30).Returns(900));
                objTestCaseData.Add(new TestCaseData(5, 5).Returns(25));
                // This arraylist can be provided from database
                foreach (TestCaseData obj in objTestCaseData)
                {
                    yield return obj;
                }


            }

        }
    }
}
