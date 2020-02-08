namespace SampleWindow
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
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdivide = new System.Windows.Forms.RadioButton();
            this.rdbmultiply = new System.Windows.Forms.RadioButton();
            this.rdbsubtract = new System.Windows.Forms.RadioButton();
            this.rdbadd = new System.Windows.Forms.RadioButton();
            this.lblsolution = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(302, 73);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 20);
            this.txtfirst.TabIndex = 0;
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(302, 139);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(100, 20);
            this.txtsecond.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter first Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter second Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdivide);
            this.groupBox1.Controls.Add(this.rdbmultiply);
            this.groupBox1.Controls.Add(this.rdbsubtract);
            this.groupBox1.Controls.Add(this.rdbadd);
            this.groupBox1.Location = new System.Drawing.Point(40, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbdivide
            // 
            this.rdbdivide.AutoSize = true;
            this.rdbdivide.Location = new System.Drawing.Point(17, 125);
            this.rdbdivide.Name = "rdbdivide";
            this.rdbdivide.Size = new System.Drawing.Size(53, 17);
            this.rdbdivide.TabIndex = 3;
            this.rdbdivide.TabStop = true;
            this.rdbdivide.Text = "divide";
            this.rdbdivide.UseVisualStyleBackColor = true;
            // 
            // rdbmultiply
            // 
            this.rdbmultiply.AutoSize = true;
            this.rdbmultiply.Location = new System.Drawing.Point(17, 92);
            this.rdbmultiply.Name = "rdbmultiply";
            this.rdbmultiply.Size = new System.Drawing.Size(59, 17);
            this.rdbmultiply.TabIndex = 2;
            this.rdbmultiply.TabStop = true;
            this.rdbmultiply.Text = "multiply";
            this.rdbmultiply.UseVisualStyleBackColor = true;
            // 
            // rdbsubtract
            // 
            this.rdbsubtract.AutoSize = true;
            this.rdbsubtract.Location = new System.Drawing.Point(14, 59);
            this.rdbsubtract.Name = "rdbsubtract";
            this.rdbsubtract.Size = new System.Drawing.Size(63, 17);
            this.rdbsubtract.TabIndex = 1;
            this.rdbsubtract.TabStop = true;
            this.rdbsubtract.Text = "subtract";
            this.rdbsubtract.UseVisualStyleBackColor = true;
            // 
            // rdbadd
            // 
            this.rdbadd.AutoSize = true;
            this.rdbadd.Location = new System.Drawing.Point(17, 31);
            this.rdbadd.Name = "rdbadd";
            this.rdbadd.Size = new System.Drawing.Size(43, 17);
            this.rdbadd.TabIndex = 0;
            this.rdbadd.TabStop = true;
            this.rdbadd.Text = "add";
            this.rdbadd.UseVisualStyleBackColor = true;
            // 
            // lblsolution
            // 
            this.lblsolution.AutoSize = true;
            this.lblsolution.Location = new System.Drawing.Point(303, 185);
            this.lblsolution.Name = "lblsolution";
            this.lblsolution.Size = new System.Drawing.Size(37, 13);
            this.lblsolution.TabIndex = 6;
            this.lblsolution.Text = "Result";
            this.lblsolution.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 369);
            this.Controls.Add(this.lblsolution);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdivide;
        private System.Windows.Forms.RadioButton rdbmultiply;
        private System.Windows.Forms.RadioButton rdbsubtract;
        private System.Windows.Forms.RadioButton rdbadd;
        private System.Windows.Forms.Label lblsolution;
    }
}

