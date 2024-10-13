namespace PingPongGame
{
    partial class RegisterForm
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
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginField.Location = new System.Drawing.Point(42, 84);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(200, 24);
            this.UserLoginField.TabIndex = 1;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.ForeColor = System.Drawing.Color.Black;
            this.RegButton.Location = new System.Drawing.Point(64, 224);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(143, 30);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "reg";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // UserEmailField
            // 
            this.UserEmailField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserEmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailField.ForeColor = System.Drawing.Color.Gray;
            this.UserEmailField.Location = new System.Drawing.Point(42, 122);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(200, 24);
            this.UserEmailField.TabIndex = 3;
            this.UserEmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserEmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(42, 165);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(200, 24);
            this.UserPasswordField.TabIndex = 4;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.linkLabel1.Location = new System.Drawing.Point(113, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Enter += new System.EventHandler(this.TextBox_Enter);
            this.Leave += new System.EventHandler(this.TextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox UserEmailField;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}