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
                objTestCaseData.Add(new TestCaseData("-1","2","4").Returns("All three sides must be numeric integer types having value greater than 0!"));
                objTestCaseData.Add(new TestCaseData("","", "20").Returns("All three sides must be numeric integer types having value greater than 0!"));
                objTestCaseData.Add(new TestCaseData("2","0", "30").Returns("All three sides must be numeric integer types having value greater than 0!"));
                objTestCaseData.Add(new TestCaseData("e","3", "t").Returns("All three sides must be numeric integer types having value greater than 0!"));
                objTestCaseData.Add(new TestCaseData("2", "3", "6").Returns("Triangle cannot be formed! Any two sides total should be grater than the third side."));
                objTestCaseData.Add(new TestCaseData("2", "3", "4").Returns(""));
                // This arraylist can be provided from database
                foreach (TestCaseData obj in objTestCaseData)
                {
                    yield return obj;
                }


            }

        }
    }
}
