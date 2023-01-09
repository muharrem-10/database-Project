
namespace project_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Actbtn = new System.Windows.Forms.Button();
            this.Mvsbtn = new System.Windows.Forms.Button();
            this.Drcbtn = new System.Windows.Forms.Button();
            this.Ctgbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select The Table You Want To Trade";
            // 
            // Actbtn
            // 
            this.Actbtn.Location = new System.Drawing.Point(173, 253);
            this.Actbtn.Name = "Actbtn";
            this.Actbtn.Size = new System.Drawing.Size(119, 36);
            this.Actbtn.TabIndex = 1;
            this.Actbtn.Text = "Cast Table";
            this.Actbtn.UseVisualStyleBackColor = true;
            this.Actbtn.Click += new System.EventHandler(this.Actbtn_Click);
            // 
            // Mvsbtn
            // 
            this.Mvsbtn.Location = new System.Drawing.Point(338, 253);
            this.Mvsbtn.Name = "Mvsbtn";
            this.Mvsbtn.Size = new System.Drawing.Size(119, 36);
            this.Mvsbtn.TabIndex = 2;
            this.Mvsbtn.Text = "Movies Table";
            this.Mvsbtn.UseVisualStyleBackColor = true;
            this.Mvsbtn.Click += new System.EventHandler(this.Mvsbtn_Click);
            // 
            // Drcbtn
            // 
            this.Drcbtn.Location = new System.Drawing.Point(338, 175);
            this.Drcbtn.Name = "Drcbtn";
            this.Drcbtn.Size = new System.Drawing.Size(119, 36);
            this.Drcbtn.TabIndex = 3;
            this.Drcbtn.Text = "Director Table";
            this.Drcbtn.UseVisualStyleBackColor = true;
            this.Drcbtn.Click += new System.EventHandler(this.Drcbtn_Click);
            // 
            // Ctgbtn
            // 
            this.Ctgbtn.Location = new System.Drawing.Point(173, 175);
            this.Ctgbtn.Name = "Ctgbtn";
            this.Ctgbtn.Size = new System.Drawing.Size(119, 36);
            this.Ctgbtn.TabIndex = 4;
            this.Ctgbtn.Text = "Categories Table";
            this.Ctgbtn.UseVisualStyleBackColor = true;
            this.Ctgbtn.Click += new System.EventHandler(this.Ctgbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(679, 430);
            this.Controls.Add(this.Ctgbtn);
            this.Controls.Add(this.Drcbtn);
            this.Controls.Add(this.Mvsbtn);
            this.Controls.Add(this.Actbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actbtn;
        private System.Windows.Forms.Button Mvsbtn;
        private System.Windows.Forms.Button Drcbtn;
        private System.Windows.Forms.Button Ctgbtn;
    }
}

