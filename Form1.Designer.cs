namespace Prog1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sqFtPaintedLbl = new System.Windows.Forms.Label();
            this.gallonsPaintLbl = new System.Windows.Forms.Label();
            this.hoursLaborLbl = new System.Windows.Forms.Label();
            this.costPaintLbl = new System.Windows.Forms.Label();
            this.costLaborLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.roomSqFtTxt = new System.Windows.Forms.TextBox();
            this.numberCoatsTxt = new System.Windows.Forms.TextBox();
            this.pricePaintTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square Feet of Room (e.g. 500.0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Coats (e.g. 3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Per Gallon of Paint (e.g. 12.75)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Square Feet Painted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Gallons of Paint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hours of Labor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cost of Paint";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cost of Labor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Cost";
            // 
            // sqFtPaintedLbl
            // 
            this.sqFtPaintedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqFtPaintedLbl.Location = new System.Drawing.Point(255, 196);
            this.sqFtPaintedLbl.Name = "sqFtPaintedLbl";
            this.sqFtPaintedLbl.Size = new System.Drawing.Size(100, 23);
            this.sqFtPaintedLbl.TabIndex = 9;
            // 
            // gallonsPaintLbl
            // 
            this.gallonsPaintLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsPaintLbl.Location = new System.Drawing.Point(255, 229);
            this.gallonsPaintLbl.Name = "gallonsPaintLbl";
            this.gallonsPaintLbl.Size = new System.Drawing.Size(100, 23);
            this.gallonsPaintLbl.TabIndex = 10;
            // 
            // hoursLaborLbl
            // 
            this.hoursLaborLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursLaborLbl.Location = new System.Drawing.Point(255, 262);
            this.hoursLaborLbl.Name = "hoursLaborLbl";
            this.hoursLaborLbl.Size = new System.Drawing.Size(100, 23);
            this.hoursLaborLbl.TabIndex = 11;
            // 
            // costPaintLbl
            // 
            this.costPaintLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintLbl.Location = new System.Drawing.Point(255, 295);
            this.costPaintLbl.Name = "costPaintLbl";
            this.costPaintLbl.Size = new System.Drawing.Size(100, 21);
            this.costPaintLbl.TabIndex = 12;
            // 
            // costLaborLbl
            // 
            this.costLaborLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLaborLbl.Location = new System.Drawing.Point(255, 326);
            this.costLaborLbl.Name = "costLaborLbl";
            this.costLaborLbl.Size = new System.Drawing.Size(100, 23);
            this.costLaborLbl.TabIndex = 13;
            // 
            // TotalLbl
            // 
            this.TotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLbl.Location = new System.Drawing.Point(255, 362);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(100, 23);
            this.TotalLbl.TabIndex = 14;
            // 
            // roomSqFtTxt
            // 
            this.roomSqFtTxt.Location = new System.Drawing.Point(255, 20);
            this.roomSqFtTxt.Name = "roomSqFtTxt";
            this.roomSqFtTxt.Size = new System.Drawing.Size(100, 20);
            this.roomSqFtTxt.TabIndex = 15;
            // 
            // numberCoatsTxt
            // 
            this.numberCoatsTxt.Location = new System.Drawing.Point(255, 46);
            this.numberCoatsTxt.Name = "numberCoatsTxt";
            this.numberCoatsTxt.Size = new System.Drawing.Size(100, 20);
            this.numberCoatsTxt.TabIndex = 16;
            // 
            // pricePaintTxt
            // 
            this.pricePaintTxt.Location = new System.Drawing.Point(255, 72);
            this.pricePaintTxt.Name = "pricePaintTxt";
            this.pricePaintTxt.Size = new System.Drawing.Size(100, 20);
            this.pricePaintTxt.TabIndex = 17;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(53, 130);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(302, 23);
            this.calculateBtn.TabIndex = 18;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 423);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.pricePaintTxt);
            this.Controls.Add(this.numberCoatsTxt);
            this.Controls.Add(this.roomSqFtTxt);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.costLaborLbl);
            this.Controls.Add(this.costPaintLbl);
            this.Controls.Add(this.hoursLaborLbl);
            this.Controls.Add(this.gallonsPaintLbl);
            this.Controls.Add(this.sqFtPaintedLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sqFtPaintedLbl;
        private System.Windows.Forms.Label gallonsPaintLbl;
        private System.Windows.Forms.Label hoursLaborLbl;
        private System.Windows.Forms.Label costPaintLbl;
        private System.Windows.Forms.Label costLaborLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.TextBox roomSqFtTxt;
        private System.Windows.Forms.TextBox numberCoatsTxt;
        private System.Windows.Forms.TextBox pricePaintTxt;
        private System.Windows.Forms.Button calculateBtn;
    }
}

