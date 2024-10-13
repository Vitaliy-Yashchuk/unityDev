namespace PingPongGame
{
    partial class EditForm
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
            this.EditBth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(300, 238);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(200, 24);
            this.UserPasswordField.TabIndex = 12;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // EditBth
            // 
            this.EditBth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBth.ForeColor = System.Drawing.Color.Black;
            this.EditBth.Location = new System.Drawing.Point(324, 328);
            this.EditBth.Name = "EditBth";
            this.EditBth.Size = new System.Drawing.Size(143, 30);
            this.EditBth.TabIndex = 11;
            this.EditBth.Text = "Edit";
            this.EditBth.UseVisualStyleBackColor = false;
            this.EditBth.Click += new System.EventHandler(this.EditBth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(322, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "User panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(279, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Edit user with login \'admin\'";
            // 
            // UserEmailField
            // 
            this.UserEmailField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.UserEmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailField.ForeColor = System.Drawing.Color.Gray;
            this.UserEmailField.Location = new System.Drawing.Point(300, 182);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(200, 24);
            this.UserEmailField.TabIndex = 14;
            this.UserEmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserEmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.EditBth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.Button EditBth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserEmailField;
    }
}