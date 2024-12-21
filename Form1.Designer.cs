namespace jeunumeroporte_bonheur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCelibataire = new System.Windows.Forms.RadioButton();
            this.radioMarie = new System.Windows.Forms.RadioButton();
            this.radioDivorce = new System.Windows.Forms.RadioButton();
            this.lblDatenaissance = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnChanger = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trouvez votre chiffre porte bonheur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDivorce);
            this.groupBox1.Controls.Add(this.radioMarie);
            this.groupBox1.Controls.Add(this.radioCelibataire);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Civilité";
            // 
            // radioCelibataire
            // 
            this.radioCelibataire.AutoSize = true;
            this.radioCelibataire.Location = new System.Drawing.Point(34, 83);
            this.radioCelibataire.Name = "radioCelibataire";
            this.radioCelibataire.Size = new System.Drawing.Size(177, 33);
            this.radioCelibataire.TabIndex = 0;
            this.radioCelibataire.TabStop = true;
            this.radioCelibataire.Text = "Celibataire";
            this.radioCelibataire.UseVisualStyleBackColor = true;
            // 
            // radioMarie
            // 
            this.radioMarie.AutoSize = true;
            this.radioMarie.Location = new System.Drawing.Point(267, 83);
            this.radioMarie.Name = "radioMarie";
            this.radioMarie.Size = new System.Drawing.Size(116, 33);
            this.radioMarie.TabIndex = 0;
            this.radioMarie.TabStop = true;
            this.radioMarie.Text = "Marié";
            this.radioMarie.UseVisualStyleBackColor = true;
            // 
            // radioDivorce
            // 
            this.radioDivorce.AutoSize = true;
            this.radioDivorce.Location = new System.Drawing.Point(452, 83);
            this.radioDivorce.Name = "radioDivorce";
            this.radioDivorce.Size = new System.Drawing.Size(137, 33);
            this.radioDivorce.TabIndex = 0;
            this.radioDivorce.TabStop = true;
            this.radioDivorce.Text = "Divorcé";
            this.radioDivorce.UseVisualStyleBackColor = true;
            // 
            // lblDatenaissance
            // 
            this.lblDatenaissance.AutoSize = true;
            this.lblDatenaissance.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatenaissance.Location = new System.Drawing.Point(20, 296);
            this.lblDatenaissance.Name = "lblDatenaissance";
            this.lblDatenaissance.Size = new System.Drawing.Size(536, 29);
            this.lblDatenaissance.TabIndex = 2;
            this.lblDatenaissance.Text = "Date de naissance au format (jj/MM/aaaa) :";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(131, 348);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(413, 31);
            this.txt_date.TabIndex = 3;
            // 
            // btnCalculer
            // 
            this.btnCalculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalculer.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(42, 439);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(269, 51);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "Rechercher";
            this.btnCalculer.UseVisualStyleBackColor = false;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnChanger
            // 
            this.btnChanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChanger.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanger.Location = new System.Drawing.Point(348, 439);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(311, 51);
            this.btnChanger.TabIndex = 4;
            this.btnChanger.Text = "Changer la couleur";
            this.btnChanger.UseVisualStyleBackColor = false;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(714, 524);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.lblDatenaissance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numero porte bonheur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDivorce;
        private System.Windows.Forms.RadioButton radioMarie;
        private System.Windows.Forms.RadioButton radioCelibataire;
        private System.Windows.Forms.Label lblDatenaissance;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnChanger;
    }
}

