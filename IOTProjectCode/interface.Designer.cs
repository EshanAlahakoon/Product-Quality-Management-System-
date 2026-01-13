namespace Product_Quality_Checker_System
{
    partial class f
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
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.resetbuttonDimensions = new System.Windows.Forms.Button();
            this.resetbuttonProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defectivedimensioncount = new System.Windows.Forms.TextBox();
            this.defectivecolourcount = new System.Windows.Forms.TextBox();
            this.goodtotalcount = new System.Windows.Forms.TextBox();
            this.greencount = new System.Windows.Forms.TextBox();
            this.bluecount = new System.Windows.Forms.TextBox();
            this.redcount = new System.Windows.Forms.TextBox();
            this.dimensionlable = new System.Windows.Forms.Label();
            this.colourlabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.heighttext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.measuredHeightText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Quality Checker System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Green;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.Transparent;
            this.startbutton.Location = new System.Drawing.Point(440, 110);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(114, 63);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.Color.Firebrick;
            this.stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopbutton.Location = new System.Drawing.Point(598, 110);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(114, 63);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.ForestGreen;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savebutton.Location = new System.Drawing.Point(281, 244);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(70, 33);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input Dimensions (cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Height";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Good";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Red";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Blue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Green";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(282, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Defective Count";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Good Total Count";
            // 
            // resetbuttonDimensions
            // 
            this.resetbuttonDimensions.BackColor = System.Drawing.Color.Chocolate;
            this.resetbuttonDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbuttonDimensions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetbuttonDimensions.Location = new System.Drawing.Point(174, 244);
            this.resetbuttonDimensions.Name = "resetbuttonDimensions";
            this.resetbuttonDimensions.Size = new System.Drawing.Size(70, 33);
            this.resetbuttonDimensions.TabIndex = 21;
            this.resetbuttonDimensions.Text = "Reset";
            this.resetbuttonDimensions.UseVisualStyleBackColor = false;
            // 
            // resetbuttonProduct
            // 
            this.resetbuttonProduct.BackColor = System.Drawing.Color.Chocolate;
            this.resetbuttonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbuttonProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetbuttonProduct.Location = new System.Drawing.Point(511, 208);
            this.resetbuttonProduct.Name = "resetbuttonProduct";
            this.resetbuttonProduct.Size = new System.Drawing.Size(95, 34);
            this.resetbuttonProduct.TabIndex = 22;
            this.resetbuttonProduct.Text = "Reset";
            this.resetbuttonProduct.UseVisualStyleBackColor = false;
            this.resetbuttonProduct.Click += new System.EventHandler(this.resetbuttonProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defectivedimensioncount);
            this.groupBox1.Controls.Add(this.defectivecolourcount);
            this.groupBox1.Controls.Add(this.goodtotalcount);
            this.groupBox1.Controls.Add(this.greencount);
            this.groupBox1.Controls.Add(this.bluecount);
            this.groupBox1.Controls.Add(this.redcount);
            this.groupBox1.Controls.Add(this.dimensionlable);
            this.groupBox1.Controls.Add(this.colourlabel);
            this.groupBox1.Controls.Add(this.resetbuttonProduct);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 248);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Count";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // defectivedimensioncount
            // 
            this.defectivedimensioncount.Location = new System.Drawing.Point(396, 109);
            this.defectivedimensioncount.Name = "defectivedimensioncount";
            this.defectivedimensioncount.Size = new System.Drawing.Size(83, 29);
            this.defectivedimensioncount.TabIndex = 32;
            // 
            // defectivecolourcount
            // 
            this.defectivecolourcount.Location = new System.Drawing.Point(396, 76);
            this.defectivecolourcount.Name = "defectivecolourcount";
            this.defectivecolourcount.Size = new System.Drawing.Size(83, 29);
            this.defectivecolourcount.TabIndex = 31;
            // 
            // goodtotalcount
            // 
            this.goodtotalcount.Location = new System.Drawing.Point(173, 191);
            this.goodtotalcount.Name = "goodtotalcount";
            this.goodtotalcount.Size = new System.Drawing.Size(83, 29);
            this.goodtotalcount.TabIndex = 30;
            // 
            // greencount
            // 
            this.greencount.Location = new System.Drawing.Point(118, 144);
            this.greencount.Name = "greencount";
            this.greencount.Size = new System.Drawing.Size(83, 29);
            this.greencount.TabIndex = 29;
            // 
            // bluecount
            // 
            this.bluecount.Location = new System.Drawing.Point(118, 109);
            this.bluecount.Name = "bluecount";
            this.bluecount.Size = new System.Drawing.Size(83, 29);
            this.bluecount.TabIndex = 28;
            // 
            // redcount
            // 
            this.redcount.Location = new System.Drawing.Point(118, 76);
            this.redcount.Name = "redcount";
            this.redcount.Size = new System.Drawing.Size(83, 29);
            this.redcount.TabIndex = 24;
            // 
            // dimensionlable
            // 
            this.dimensionlable.AutoSize = true;
            this.dimensionlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionlable.Location = new System.Drawing.Point(282, 118);
            this.dimensionlable.Name = "dimensionlable";
            this.dimensionlable.Size = new System.Drawing.Size(84, 20);
            this.dimensionlable.TabIndex = 26;
            this.dimensionlable.Text = "Dimension";
            // 
            // colourlabel
            // 
            this.colourlabel.AutoSize = true;
            this.colourlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourlabel.Location = new System.Drawing.Point(282, 85);
            this.colourlabel.Name = "colourlabel";
            this.colourlabel.Size = new System.Drawing.Size(55, 20);
            this.colourlabel.TabIndex = 23;
            this.colourlabel.Text = "Colour";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(440, 215);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(272, 26);
            this.outputTextBox.TabIndex = 33;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // heighttext
            // 
            this.heighttext.Location = new System.Drawing.Point(174, 185);
            this.heighttext.Name = "heighttext";
            this.heighttext.Size = new System.Drawing.Size(177, 26);
            this.heighttext.TabIndex = 6;
            this.heighttext.TextChanged += new System.EventHandler(this.heighttext_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Status";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // measuredHeightText
            // 
            this.measuredHeightText.Location = new System.Drawing.Point(440, 280);
            this.measuredHeightText.Name = "measuredHeightText";
            this.measuredHeightText.Size = new System.Drawing.Size(272, 26);
            this.measuredHeightText.TabIndex = 35;
            this.measuredHeightText.TextChanged += new System.EventHandler(this.measuredHeightText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Measured Height";
            // 
            // f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 598);
            this.Controls.Add(this.measuredHeightText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetbuttonDimensions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heighttext);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "f";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button resetbuttonDimensions;
        private System.Windows.Forms.Button resetbuttonProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label colourlabel;
        private System.Windows.Forms.Label dimensionlable;
        private System.Windows.Forms.TextBox redcount;
        private System.Windows.Forms.TextBox goodtotalcount;
        private System.Windows.Forms.TextBox greencount;
        private System.Windows.Forms.TextBox bluecount;
        private System.Windows.Forms.TextBox defectivedimensioncount;
        private System.Windows.Forms.TextBox defectivecolourcount;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox heighttext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox measuredHeightText;
        private System.Windows.Forms.Label label3;
    }
}

