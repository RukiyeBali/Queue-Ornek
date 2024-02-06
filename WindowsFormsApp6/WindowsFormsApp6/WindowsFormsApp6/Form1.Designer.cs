namespace WindowsFormsApp6
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
            this.btnGise1 = new System.Windows.Forms.Button();
            this.btnGise2 = new System.Windows.Forms.Button();
            this.btnGise3 = new System.Windows.Forms.Button();
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.lblSiraAl = new System.Windows.Forms.Label();
            this.lblGise1 = new System.Windows.Forms.Label();
            this.lblGise2 = new System.Windows.Forms.Label();
            this.lblGise3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGise1
            // 
            this.btnGise1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGise1.Location = new System.Drawing.Point(33, 35);
            this.btnGise1.Name = "btnGise1";
            this.btnGise1.Size = new System.Drawing.Size(152, 76);
            this.btnGise1.TabIndex = 0;
            this.btnGise1.Text = "GİŞE 1";
            this.btnGise1.UseVisualStyleBackColor = true;
            this.btnGise1.Click += new System.EventHandler(this.btnGise1_Click);
            // 
            // btnGise2
            // 
            this.btnGise2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGise2.Location = new System.Drawing.Point(326, 35);
            this.btnGise2.Name = "btnGise2";
            this.btnGise2.Size = new System.Drawing.Size(152, 76);
            this.btnGise2.TabIndex = 1;
            this.btnGise2.Text = "GİŞE 2";
            this.btnGise2.UseVisualStyleBackColor = true;
            this.btnGise2.Click += new System.EventHandler(this.btnGise2_Click);
            // 
            // btnGise3
            // 
            this.btnGise3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGise3.Location = new System.Drawing.Point(621, 35);
            this.btnGise3.Name = "btnGise3";
            this.btnGise3.Size = new System.Drawing.Size(152, 76);
            this.btnGise3.TabIndex = 2;
            this.btnGise3.Text = "GİŞE 3";
            this.btnGise3.UseVisualStyleBackColor = true;
            this.btnGise3.Click += new System.EventHandler(this.btnGise3_Click);
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiraAl.Location = new System.Drawing.Point(307, 298);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(234, 125);
            this.btnSiraAl.TabIndex = 3;
            this.btnSiraAl.Text = "SIRA AL";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // lblSiraAl
            // 
            this.lblSiraAl.AutoSize = true;
            this.lblSiraAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiraAl.Location = new System.Drawing.Point(408, 258);
            this.lblSiraAl.Name = "lblSiraAl";
            this.lblSiraAl.Size = new System.Drawing.Size(35, 37);
            this.lblSiraAl.TabIndex = 4;
            this.lblSiraAl.Text = "0";
            // 
            // lblGise1
            // 
            this.lblGise1.AutoSize = true;
            this.lblGise1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGise1.Location = new System.Drawing.Point(96, 134);
            this.lblGise1.Name = "lblGise1";
            this.lblGise1.Size = new System.Drawing.Size(35, 37);
            this.lblGise1.TabIndex = 5;
            this.lblGise1.Text = "0";
            // 
            // lblGise2
            // 
            this.lblGise2.AutoSize = true;
            this.lblGise2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGise2.Location = new System.Drawing.Point(388, 134);
            this.lblGise2.Name = "lblGise2";
            this.lblGise2.Size = new System.Drawing.Size(35, 37);
            this.lblGise2.TabIndex = 6;
            this.lblGise2.Text = "0";
            // 
            // lblGise3
            // 
            this.lblGise3.AutoSize = true;
            this.lblGise3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGise3.Location = new System.Drawing.Point(685, 134);
            this.lblGise3.Name = "lblGise3";
            this.lblGise3.Size = new System.Drawing.Size(35, 37);
            this.lblGise3.TabIndex = 7;
            this.lblGise3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 451);
            this.Controls.Add(this.lblGise3);
            this.Controls.Add(this.lblGise2);
            this.Controls.Add(this.lblGise1);
            this.Controls.Add(this.lblSiraAl);
            this.Controls.Add(this.btnSiraAl);
            this.Controls.Add(this.btnGise3);
            this.Controls.Add(this.btnGise2);
            this.Controls.Add(this.btnGise1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGise1;
        private System.Windows.Forms.Button btnGise2;
        private System.Windows.Forms.Button btnGise3;
        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Label lblSiraAl;
        private System.Windows.Forms.Label lblGise1;
        private System.Windows.Forms.Label lblGise2;
        private System.Windows.Forms.Label lblGise3;
    }
}

