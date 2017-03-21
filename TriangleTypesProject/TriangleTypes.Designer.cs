namespace TriangleTypesProject
{
    partial class TriangleTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSideALength = new System.Windows.Forms.TextBox();
            this.txtSideBLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSideCLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckTriangleType = new System.Windows.Forms.Button();
            this.lblValidationMessage = new System.Windows.Forms.Label();
            this.lblTriangleType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side A Length";
            // 
            // txtSideALength
            // 
            this.txtSideALength.Location = new System.Drawing.Point(159, 93);
            this.txtSideALength.Name = "txtSideALength";
            this.txtSideALength.Size = new System.Drawing.Size(100, 20);
            this.txtSideALength.TabIndex = 1;
            // 
            // txtSideBLength
            // 
            this.txtSideBLength.Location = new System.Drawing.Point(159, 120);
            this.txtSideBLength.Name = "txtSideBLength";
            this.txtSideBLength.Size = new System.Drawing.Size(100, 20);
            this.txtSideBLength.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Side B Length";
            // 
            // txtSideCLength
            // 
            this.txtSideCLength.Location = new System.Drawing.Point(159, 146);
            this.txtSideCLength.Name = "txtSideCLength";
            this.txtSideCLength.Size = new System.Drawing.Size(100, 20);
            this.txtSideCLength.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Side C Length";
            // 
            // btnCheckTriangleType
            // 
            this.btnCheckTriangleType.Location = new System.Drawing.Point(102, 182);
            this.btnCheckTriangleType.Name = "btnCheckTriangleType";
            this.btnCheckTriangleType.Size = new System.Drawing.Size(157, 23);
            this.btnCheckTriangleType.TabIndex = 6;
            this.btnCheckTriangleType.Text = "Check Triangle Type";
            this.btnCheckTriangleType.UseVisualStyleBackColor = true;
            this.btnCheckTriangleType.Click += new System.EventHandler(this.btnCheckTriangleType_Click);
            // 
            // lblValidationMessage
            // 
            this.lblValidationMessage.AutoSize = true;
            this.lblValidationMessage.ForeColor = System.Drawing.Color.Red;
            this.lblValidationMessage.Location = new System.Drawing.Point(99, 208);
            this.lblValidationMessage.Name = "lblValidationMessage";
            this.lblValidationMessage.Size = new System.Drawing.Size(0, 13);
            this.lblValidationMessage.TabIndex = 7;
            // 
            // lblTriangleType
            // 
            this.lblTriangleType.AutoSize = true;
            this.lblTriangleType.ForeColor = System.Drawing.Color.Green;
            this.lblTriangleType.Location = new System.Drawing.Point(99, 229);
            this.lblTriangleType.Name = "lblTriangleType";
            this.lblTriangleType.Size = new System.Drawing.Size(0, 13);
            this.lblTriangleType.TabIndex = 8;
            // 
            // TriangleTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 368);
            this.Controls.Add(this.lblTriangleType);
            this.Controls.Add(this.lblValidationMessage);
            this.Controls.Add(this.btnCheckTriangleType);
            this.Controls.Add(this.txtSideCLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSideBLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSideALength);
            this.Controls.Add(this.label1);
            this.Name = "TriangleTypes";
            this.Text = "TriangleTypes";
            this.Load += new System.EventHandler(this.TriangleTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSideALength;
        private System.Windows.Forms.TextBox txtSideBLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSideCLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckTriangleType;
        private System.Windows.Forms.Label lblValidationMessage;
        private System.Windows.Forms.Label lblTriangleType;
    }
}