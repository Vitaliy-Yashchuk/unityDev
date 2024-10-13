namespace PingPongGame
{
    partial class Menu
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
            this.EditBth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartGameBth = new System.Windows.Forms.Button();
            this.ExitBth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditBth
            // 
            this.EditBth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBth.ForeColor = System.Drawing.Color.Black;
            this.EditBth.Location = new System.Drawing.Point(60, 172);
            this.EditBth.Name = "EditBth";
            this.EditBth.Size = new System.Drawing.Size(143, 30);
            this.EditBth.TabIndex = 12;
            this.EditBth.Text = "Edit profile";
            this.EditBth.UseVisualStyleBackColor = false;
            this.EditBth.Click += new System.EventHandler(this.EditBth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(96, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu :)";
            // 
            // StartGameBth
            // 
            this.StartGameBth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartGameBth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameBth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBth.ForeColor = System.Drawing.Color.Black;
            this.StartGameBth.Location = new System.Drawing.Point(60, 122);
            this.StartGameBth.Name = "StartGameBth";
            this.StartGameBth.Size = new System.Drawing.Size(143, 30);
            this.StartGameBth.TabIndex = 13;
            this.StartGameBth.Text = "Start Game";
            this.StartGameBth.UseVisualStyleBackColor = false;
            this.StartGameBth.Click += new System.EventHandler(this.StartGameBth_Click);
            // 
            // ExitBth
            // 
            this.ExitBth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBth.ForeColor = System.Drawing.Color.Black;
            this.ExitBth.Location = new System.Drawing.Point(60, 224);
            this.ExitBth.Name = "ExitBth";
            this.ExitBth.Size = new System.Drawing.Size(143, 30);
            this.ExitBth.TabIndex = 14;
            this.ExitBth.Text = "Exit";
            this.ExitBth.UseVisualStyleBackColor = false;
            this.ExitBth.Click += new System.EventHandler(this.ExitBth_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(263, 318);
            this.Controls.Add(this.ExitBth);
            this.Controls.Add(this.StartGameBth);
            this.Controls.Add(this.EditBth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditBth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartGameBth;
        private System.Windows.Forms.Button ExitBth;
    }
}