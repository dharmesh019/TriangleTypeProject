using InterfaceTriangle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryTriangleNameSpace;


namespace TriangleTypesProject
{
    public partial class TriangleTypes : Form
    {
        // no direct referece to repo project decoupling is achieved here as only interface project and factory project is referece in this main project
        private ITriangle TriangleObj = null;
        public TriangleTypes()
        {
            InitializeComponent();
        }

        
        private void btnCheckTriangleType_Click(object sender, EventArgs e)
        {
            //handle the errors and display the message properly
            try
            {
                lblValidationMessage.Text = "";
                lblTriangleType.Text = "";
                TriangleObj.SideALength = txtSideALength.Text;
                TriangleObj.SideBLength = txtSideBLength.Text;
                TriangleObj.SideCLength = txtSideCLength.Text;
                var ValidationMessage = TriangleObj.ValidateTriangleSideInputs();
                if (!String.IsNullOrEmpty(ValidationMessage))
                {
                    lblValidationMessage.Text = ValidationMessage;
                }
                else
                { 
                    //Here Check For Triangle Type 
                     var TriangleTypeString = TriangleObj.CalculateTriangleType( Convert.ToInt16( TriangleObj.SideALength),Convert.ToInt16( TriangleObj.SideBLength), Convert.ToInt16( TriangleObj.SideCLength));
                    lblTriangleType.Text = "This is " +  TriangleTypeString + " triangle";
                }
            }
            catch(Exception ex) // here shows the exception message thrown if any validation error is there
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TriangleTypes_Load(object sender, EventArgs e)
        {
            //when form is loaded, all dependant class objects are created here using simple factory pattern
            TriangleObj = FactoryTriangle.Create();
        }
    }
}
