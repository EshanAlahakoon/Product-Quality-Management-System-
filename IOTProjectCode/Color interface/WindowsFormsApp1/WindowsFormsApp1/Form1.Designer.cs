namespace WindowsFormsApp1
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
            this.redcount = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.totalcount = new System.Windows.Forms.TextBox();
            this.greencount = new System.Windows.Forms.TextBox();
            this.bluecount = new System.Windows.Forms.TextBox();
            this.resetbuttonProduct = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.defectivecount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Green";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Red";
            // 
            // redcount
            // 
            this.redcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redcount.Location = new System.Drawing.Point(255, 139);
            this.redcount.Margin = new System.Windows.Forms.Padding(2);
            this.redcount.Name = "redcount";
            this.redcount.Size = new System.Drawing.Size(87, 35);
            this.redcount.TabIndex = 5;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(255, 55);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(277, 35);
            this.outputTextBox.TabIndex = 6;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // totalcount
            // 
            this.totalcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcount.Location = new System.Drawing.Point(311, 340);
            this.totalcount.Margin = new System.Windows.Forms.Padding(2);
            this.totalcount.Name = "totalcount";
            this.totalcount.Size = new System.Drawing.Size(87, 35);
            this.totalcount.TabIndex = 7;
            // 
            // greencount
            // 
            this.greencount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greencount.Location = new System.Drawing.Point(255, 271);
            this.greencount.Margin = new System.Windows.Forms.Padding(2);
            this.greencount.Name = "greencount";
            this.greencount.Size = new System.Drawing.Size(87, 35);
            this.greencount.TabIndex = 8;
            // 
            // bluecount
            // 
            this.bluecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluecount.Location = new System.Drawing.Point(255, 205);
            this.bluecount.Margin = new System.Windows.Forms.Padding(2);
            this.bluecount.Name = "bluecount";
            this.bluecount.Size = new System.Drawing.Size(87, 35);
            this.bluecount.TabIndex = 9;
            // 
            // resetbuttonProduct
            // 
            this.resetbuttonProduct.AutoSize = true;
            this.resetbuttonProduct.BackColor = System.Drawing.Color.Red;
            this.resetbuttonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbuttonProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetbuttonProduct.Location = new System.Drawing.Point(538, 340);
            this.resetbuttonProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resetbuttonProduct.Name = "resetbuttonProduct";
            this.resetbuttonProduct.Size = new System.Drawing.Size(81, 29);
            this.resetbuttonProduct.TabIndex = 10;
            this.resetbuttonProduct.Text = "Reset";
            this.resetbuttonProduct.Click += new System.EventHandler(this.resetbuttonProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Defective Count";
            // 
            // defectivecount
            // 
            this.defectivecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectivecount.Location = new System.Drawing.Point(483, 214);
            this.defectivecount.Margin = new System.Windows.Forms.Padding(2);
            this.defectivecount.Name = "defectivecount";
            this.defectivecount.Size = new System.Drawing.Size(87, 35);
            this.defectivecount.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(696, 438);
            this.Controls.Add(this.defectivecount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resetbuttonProduct);
            this.Controls.Add(this.bluecount);
            this.Controls.Add(this.greencount);
            this.Controls.Add(this.totalcount);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.redcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox redcount;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox totalcount;
        private System.Windows.Forms.TextBox greencount;
        private System.Windows.Forms.TextBox bluecount;
        private System.Windows.Forms.Label resetbuttonProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox defectivecount;
    }
}

