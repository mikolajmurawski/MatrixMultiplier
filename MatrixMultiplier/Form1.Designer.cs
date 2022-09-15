namespace MatrixMultiplier
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.label_matrix1 = new System.Windows.Forms.Label();
            this.label_matrix2 = new System.Windows.Forms.Label();
            this.label_m1RowsNumber = new System.Windows.Forms.Label();
            this.label_m1ColumnsNumber = new System.Windows.Forms.Label();
            this.label_m2RowsNumber = new System.Windows.Forms.Label();
            this.label_m2ColumnsNumber = new System.Windows.Forms.Label();
            this.textbox_m1r = new System.Windows.Forms.TextBox();
            this.textbox_m1c = new System.Windows.Forms.TextBox();
            this.textbox_m2r = new System.Windows.Forms.TextBox();
            this.textbox_m2c = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_matrix1
            // 
            this.label_matrix1.AutoSize = true;
            this.label_matrix1.Location = new System.Drawing.Point(112, 10);
            this.label_matrix1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_matrix1.Name = "label_matrix1";
            this.label_matrix1.Size = new System.Drawing.Size(70, 15);
            this.label_matrix1.TabIndex = 0;
            this.label_matrix1.Text = "Matrix no. 1";
            // 
            // label_matrix2
            // 
            this.label_matrix2.AutoSize = true;
            this.label_matrix2.Location = new System.Drawing.Point(348, 10);
            this.label_matrix2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_matrix2.Name = "label_matrix2";
            this.label_matrix2.Size = new System.Drawing.Size(70, 15);
            this.label_matrix2.TabIndex = 1;
            this.label_matrix2.Text = "Matrix no. 2";
            // 
            // label_m1RowsNumber
            // 
            this.label_m1RowsNumber.AutoSize = true;
            this.label_m1RowsNumber.Location = new System.Drawing.Point(21, 38);
            this.label_m1RowsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_m1RowsNumber.Name = "label_m1RowsNumber";
            this.label_m1RowsNumber.Size = new System.Drawing.Size(80, 15);
            this.label_m1RowsNumber.TabIndex = 2;
            this.label_m1RowsNumber.Text = "Rows number";
            // 
            // label_m1ColumnsNumber
            // 
            this.label_m1ColumnsNumber.AutoSize = true;
            this.label_m1ColumnsNumber.Location = new System.Drawing.Point(4, 68);
            this.label_m1ColumnsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_m1ColumnsNumber.Name = "label_m1ColumnsNumber";
            this.label_m1ColumnsNumber.Size = new System.Drawing.Size(102, 15);
            this.label_m1ColumnsNumber.TabIndex = 3;
            this.label_m1ColumnsNumber.Text = "Columns Number";
            // 
            // label_m2RowsNumber
            // 
            this.label_m2RowsNumber.AutoSize = true;
            this.label_m2RowsNumber.Location = new System.Drawing.Point(257, 38);
            this.label_m2RowsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_m2RowsNumber.Name = "label_m2RowsNumber";
            this.label_m2RowsNumber.Size = new System.Drawing.Size(80, 15);
            this.label_m2RowsNumber.TabIndex = 4;
            this.label_m2RowsNumber.Text = "Rows number";
            // 
            // label_m2ColumnsNumber
            // 
            this.label_m2ColumnsNumber.AutoSize = true;
            this.label_m2ColumnsNumber.Location = new System.Drawing.Point(239, 68);
            this.label_m2ColumnsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_m2ColumnsNumber.Name = "label_m2ColumnsNumber";
            this.label_m2ColumnsNumber.Size = new System.Drawing.Size(102, 15);
            this.label_m2ColumnsNumber.TabIndex = 5;
            this.label_m2ColumnsNumber.Text = "Columns Number";
            // 
            // textbox_m1r
            // 
            this.textbox_m1r.Location = new System.Drawing.Point(112, 35);
            this.textbox_m1r.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_m1r.Name = "textbox_m1r";
            this.textbox_m1r.Size = new System.Drawing.Size(116, 23);
            this.textbox_m1r.TabIndex = 6;
            // 
            // textbox_m1c
            // 
            this.textbox_m1c.Location = new System.Drawing.Point(112, 65);
            this.textbox_m1c.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_m1c.Name = "textbox_m1c";
            this.textbox_m1c.Size = new System.Drawing.Size(116, 23);
            this.textbox_m1c.TabIndex = 7;
            // 
            // textbox_m2r
            // 
            this.textbox_m2r.Location = new System.Drawing.Point(348, 35);
            this.textbox_m2r.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_m2r.Name = "textbox_m2r";
            this.textbox_m2r.Size = new System.Drawing.Size(116, 23);
            this.textbox_m2r.TabIndex = 8;
            // 
            // textbox_m2c
            // 
            this.textbox_m2c.Location = new System.Drawing.Point(348, 65);
            this.textbox_m2c.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_m2c.Name = "textbox_m2c";
            this.textbox_m2c.Size = new System.Drawing.Size(116, 23);
            this.textbox_m2c.TabIndex = 9;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(348, 95);
            this.button_next.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(117, 27);
            this.button_next.TabIndex = 10;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 127);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textbox_m2c);
            this.Controls.Add(this.textbox_m2r);
            this.Controls.Add(this.textbox_m1c);
            this.Controls.Add(this.textbox_m1r);
            this.Controls.Add(this.label_m2ColumnsNumber);
            this.Controls.Add(this.label_m2RowsNumber);
            this.Controls.Add(this.label_m1ColumnsNumber);
            this.Controls.Add(this.label_m1RowsNumber);
            this.Controls.Add(this.label_matrix2);
            this.Controls.Add(this.label_matrix1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label_matrix1;
        private System.Windows.Forms.Label label_matrix2;
        private System.Windows.Forms.Label label_m1RowsNumber;
        private System.Windows.Forms.Label label_m1ColumnsNumber;
        private System.Windows.Forms.Label label_m2RowsNumber;
        private System.Windows.Forms.Label label_m2ColumnsNumber;
        private System.Windows.Forms.TextBox textbox_m1r;
        private System.Windows.Forms.TextBox textbox_m1c;
        private System.Windows.Forms.TextBox textbox_m2r;
        private System.Windows.Forms.TextBox textbox_m2c;
        private System.Windows.Forms.Button button_next;
    }
}