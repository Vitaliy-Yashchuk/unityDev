namespace PingPongGame
{
    partial class AuthForm
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
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sign_in = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(44, 130);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(200, 24);
            this.UserPasswordField.TabIndex = 8;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.ForeColor = System.Drawing.Color.Black;
            this.AuthButton.Location = new System.Drawing.Point(68, 199);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(143, 30);
            this.AuthButton.TabIndex = 7;
            this.AuthButton.Text = "auth";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click_1);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginField.Location = new System.Drawing.Point(44, 76);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(200, 24);
            this.UserLoginField.TabIndex = 6;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(85, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autorization";
            // 
            // Sign_in
            // 
            this.Sign_in.AutoSize = true;
            this.Sign_in.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Sign_in.Location = new System.Drawing.Point(114, 258);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(39, 13);
            this.Sign_in.TabIndex = 9;
            this.Sign_in.TabStop = true;
            this.Sign_in.Text = "Sign in";
            this.Sign_in.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.Sign_in);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Sign_in;
    }
}