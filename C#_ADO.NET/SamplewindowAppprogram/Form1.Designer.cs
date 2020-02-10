namespace SamplewindowAppprogram
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
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbsubtract = new System.Windows.Forms.RadioButton();
            this.rdbmultiply = new System.Windows.Forms.RadioButton();
            this.rdbdivide = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(257, 140);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(100, 20);
            this.txtsecond.TabIndex = 0;
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(257, 88);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(100, 20);
            this.txtfirst.TabIndex = 1;
            this.txtfirst.TextChanged += new System.EventHandler(this.txtfirst_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Controls.Add(this.rdbdivide);
            this.groupBox1.Controls.Add(this.rdbmultiply);
            this.groupBox1.Controls.Add(this.rdbsubtract);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbsubtract
            // 
            this.rdbsubtract.AutoSize = true;
            this.rdbsubtract.Location = new System.Drawing.Point(6, 39);
            this.rdbsubtract.Name = "rdbsubtract";
            this.rdbsubtract.Size = new System.Drawing.Size(63, 17);
            this.rdbsubtract.TabIndex = 1;
            this.rdbsubtract.TabStop = true;
            this.rdbsubtract.Text = "subtract";
            this.rdbsubtract.UseVisualStyleBackColor = true;
            // 
            // rdbmultiply
            // 
            this.rdbmultiply.AutoSize = true;
            this.rdbmultiply.Location = new System.Drawing.Point(6, 62);
            this.rdbmultiply.Name = "rdbmultiply";
            this.rdbmultiply.Size = new System.Drawing.Size(59, 17);
            this.rdbmultiply.TabIndex = 2;
            this.rdbmultiply.TabStop = true;
            this.rdbmultiply.Text = "multiply";
            this.rdbmultiply.UseVisualStyleBackColor = true;
            // 
            // rdbdivide
            // 
            this.rdbdivide.AutoSize = true;
            this.rdbdivide.Location = new System.Drawing.Point(6, 85);
            this.rdbdivide.Name = "rdbdivide";
            this.rdbdivide.Size = new System.Drawing.Size(53, 17);
            this.rdbdivide.TabIndex = 3;
            this.rdbdivide.TabStop = true;
            this.rdbdivide.Text = "divide";
            this.rdbdivide.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(6, 19);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(44, 17);
            this.rdbAdd.TabIndex = 4;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.txtsecond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdivide;
        private System.Windows.Forms.RadioButton rdbmultiply;
        private System.Windows.Forms.RadioButton rdbsubtract;
        private System.Windows.Forms.RadioButton rdbAdd;
    }
}

