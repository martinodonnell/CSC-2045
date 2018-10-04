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
            this.sumbitRegisterUser = new System.Windows.Forms.Button();
            this.emaiLbl = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumbitRegisterUser
            // 
            this.sumbitRegisterUser.Location = new System.Drawing.Point(202, 230);
            this.sumbitRegisterUser.Name = "sumbitRegisterUser";
            this.sumbitRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.sumbitRegisterUser.TabIndex = 0;
            this.sumbitRegisterUser.Text = "Submit";
            this.sumbitRegisterUser.UseVisualStyleBackColor = true;
            this.sumbitRegisterUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // emaiLbl
            // 
            this.emaiLbl.AutoSize = true;
            this.emaiLbl.Location = new System.Drawing.Point(199, 121);
            this.emaiLbl.Name = "emaiLbl";
            this.emaiLbl.Size = new System.Drawing.Size(32, 13);
            this.emaiLbl.TabIndex = 1;
            this.emaiLbl.Text = "Email";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(263, 118);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.emailTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(263, 163);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(199, 166);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(202, 311);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.emaiLbl);
            this.Controls.Add(this.sumbitRegisterUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumbitRegisterUser;
        private System.Windows.Forms.Label emaiLbl;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}

