namespace WelcomeAppWindowsForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurrname = new System.Windows.Forms.Label();
            this.textboxSurrname = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelStatement1 = new System.Windows.Forms.Label();
            this.labelStatement2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = " Name :";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(133, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSurrname
            // 
            this.labelSurrname.AutoSize = true;
            this.labelSurrname.Location = new System.Drawing.Point(46, 87);
            this.labelSurrname.Name = "labelSurrname";
            this.labelSurrname.Size = new System.Drawing.Size(78, 17);
            this.labelSurrname.TabIndex = 2;
            this.labelSurrname.Text = "Surrname :";
            // 
            // textboxSurrname
            // 
            this.textboxSurrname.Location = new System.Drawing.Point(133, 82);
            this.textboxSurrname.Name = "textboxSurrname";
            this.textboxSurrname.Size = new System.Drawing.Size(100, 22);
            this.textboxSurrname.TabIndex = 3;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(46, 125);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(41, 17);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age :";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(133, 120);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(133, 175);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelStatement1
            // 
            this.labelStatement1.AutoSize = true;
            this.labelStatement1.Location = new System.Drawing.Point(46, 256);
            this.labelStatement1.Name = "labelStatement1";
            this.labelStatement1.Size = new System.Drawing.Size(0, 17);
            this.labelStatement1.TabIndex = 7;
            // 
            // labelStatement2
            // 
            this.labelStatement2.AutoSize = true;
            this.labelStatement2.Location = new System.Drawing.Point(46, 302);
            this.labelStatement2.Name = "labelStatement2";
            this.labelStatement2.Size = new System.Drawing.Size(0, 17);
            this.labelStatement2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatement2);
            this.Controls.Add(this.labelStatement1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textboxSurrname);
            this.Controls.Add(this.labelSurrname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "WelcomeApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurrname;
        private System.Windows.Forms.TextBox textboxSurrname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelStatement1;
        private System.Windows.Forms.Label labelStatement2;
    }
}

