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

namespace TriangleTypesProject
{
    public partial class TriangleTypes : Form
    {
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
                TriangleObj.ValidateTriangleSideInputs();
                //Here Check For Triangle Type 
               var TriangleTypeString= TriangleObj.CalculateTriangleType(TriangleObj.SideALength,TriangleObj.SideBLength,TriangleObj.SideCLength);
               
            }
            catch(Exception ex) // here shows the exception message thrown if any validation error is there
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
