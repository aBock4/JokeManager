
namespace jokeGUI
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
            this.UCIDtxt = new System.Windows.Forms.TextBox();
            this.UCIDlbl = new System.Windows.Forms.Label();
            this.Joketxt = new System.Windows.Forms.TextBox();
            this.Jokelbl = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.goodResultlbl = new System.Windows.Forms.Label();
            this.badResultlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UCIDtxt
            // 
            this.UCIDtxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UCIDtxt.Location = new System.Drawing.Point(296, 72);
            this.UCIDtxt.Name = "UCIDtxt";
            this.UCIDtxt.Size = new System.Drawing.Size(163, 22);
            this.UCIDtxt.TabIndex = 0;
            // 
            // UCIDlbl
            // 
            this.UCIDlbl.AutoSize = true;
            this.UCIDlbl.Location = new System.Drawing.Point(305, 97);
            this.UCIDlbl.Name = "UCIDlbl";
            this.UCIDlbl.Size = new System.Drawing.Size(148, 16);
            this.UCIDlbl.TabIndex = 1;
            this.UCIDlbl.Tag = "";
            this.UCIDlbl.Text = "Please enter your UCID";
            // 
            // Joketxt
            // 
            this.Joketxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Joketxt.Location = new System.Drawing.Point(280, 127);
            this.Joketxt.Multiline = true;
            this.Joketxt.Name = "Joketxt";
            this.Joketxt.Size = new System.Drawing.Size(198, 87);
            this.Joketxt.TabIndex = 2;
            // 
            // Jokelbl
            // 
            this.Jokelbl.AutoSize = true;
            this.Jokelbl.Location = new System.Drawing.Point(305, 217);
            this.Jokelbl.Name = "Jokelbl";
            this.Jokelbl.Size = new System.Drawing.Size(142, 16);
            this.Jokelbl.TabIndex = 3;
            this.Jokelbl.Text = "Please enter your joke";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.ForeColor = System.Drawing.Color.Cornsilk;
            this.Submit.Location = new System.Drawing.Point(280, 268);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(198, 40);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit to Database";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // goodResultlbl
            // 
            this.goodResultlbl.AutoSize = true;
            this.goodResultlbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.goodResultlbl.Location = new System.Drawing.Point(256, 321);
            this.goodResultlbl.Name = "goodResultlbl";
            this.goodResultlbl.Size = new System.Drawing.Size(246, 16);
            this.goodResultlbl.TabIndex = 5;
            this.goodResultlbl.Text = "Your joke has successfully been added.";
            this.goodResultlbl.Visible = false;
            // 
            // badResultlbl
            // 
            this.badResultlbl.AutoSize = true;
            this.badResultlbl.ForeColor = System.Drawing.Color.Firebrick;
            this.badResultlbl.Location = new System.Drawing.Point(265, 355);
            this.badResultlbl.Name = "badResultlbl";
            this.badResultlbl.Size = new System.Drawing.Size(226, 16);
            this.badResultlbl.TabIndex = 6;
            this.badResultlbl.Text = "There was an error adding your joke.";
            this.badResultlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.badResultlbl);
            this.Controls.Add(this.goodResultlbl);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Jokelbl);
            this.Controls.Add(this.Joketxt);
            this.Controls.Add(this.UCIDlbl);
            this.Controls.Add(this.UCIDtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UCIDtxt;
        private System.Windows.Forms.Label UCIDlbl;
        private System.Windows.Forms.TextBox Joketxt;
        private System.Windows.Forms.Label Jokelbl;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label goodResultlbl;
        private System.Windows.Forms.Label badResultlbl;
    }
}

