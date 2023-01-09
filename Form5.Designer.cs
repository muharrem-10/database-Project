
namespace project_2
{
    partial class Form5
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
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.txtpublish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpopularity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrates = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(527, 348);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(93, 51);
            this.btnsil.TabIndex = 39;
            this.btnsil.Text = "DELETE";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Location = new System.Drawing.Point(638, 348);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(93, 51);
            this.btngüncelle.TabIndex = 38;
            this.btngüncelle.Text = "UPDATE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(412, 348);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(93, 51);
            this.btnekle.TabIndex = 37;
            this.btnekle.Text = "İNSERT";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(169, 306);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(116, 20);
            this.txtname.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Film Name";
            // 
            // txtbirth
            // 
            this.txtbirth.Location = new System.Drawing.Point(169, 358);
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.Size = new System.Drawing.Size(116, 20);
            this.txtbirth.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Description";
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(169, 332);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(116, 20);
            this.txtsurname.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Time";
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(169, 462);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(116, 20);
            this.txtcountry.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Director İd";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(169, 280);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(116, 20);
            this.txtid.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "id";
            // 
            // dgwlist
            // 
            this.dgwlist.AllowUserToAddRows = false;
            this.dgwlist.AllowUserToDeleteRows = false;
            this.dgwlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwlist.Location = new System.Drawing.Point(54, 25);
            this.dgwlist.Name = "dgwlist";
            this.dgwlist.ReadOnly = true;
            this.dgwlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwlist.Size = new System.Drawing.Size(723, 216);
            this.dgwlist.TabIndex = 25;
            this.dgwlist.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwlist_CellEnter);
            // 
            // txtpublish
            // 
            this.txtpublish.Location = new System.Drawing.Point(169, 384);
            this.txtpublish.Name = "txtpublish";
            this.txtpublish.Size = new System.Drawing.Size(116, 20);
            this.txtpublish.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Publish Date";
            // 
            // txtpopularity
            // 
            this.txtpopularity.Location = new System.Drawing.Point(169, 436);
            this.txtpopularity.Name = "txtpopularity";
            this.txtpopularity.Size = new System.Drawing.Size(116, 20);
            this.txtpopularity.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Popularity";
            // 
            // txtrates
            // 
            this.txtrates.Location = new System.Drawing.Point(169, 410);
            this.txtrates.Name = "txtrates";
            this.txtrates.Size = new System.Drawing.Size(116, 20);
            this.txtrates.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Imdb Rate";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 523);
            this.Controls.Add(this.txtpopularity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtrates);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpublish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwlist);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.TextBox txtpublish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpopularity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrates;
        private System.Windows.Forms.Label label8;
    }
}