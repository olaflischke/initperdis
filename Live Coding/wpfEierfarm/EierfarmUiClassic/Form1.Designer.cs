
namespace EierfarmUiClassic
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
            this.cbxTiere = new System.Windows.Forms.ComboBox();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnFuettern = new System.Windows.Forms.Button();
            this.btnEiLegen = new System.Windows.Forms.Button();
            this.pgdTier = new System.Windows.Forms.PropertyGrid();
            this.btnSchnabeltier = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLaden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTiere
            // 
            this.cbxTiere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiere.FormattingEnabled = true;
            this.cbxTiere.Location = new System.Drawing.Point(72, 12);
            this.cbxTiere.Name = "cbxTiere";
            this.cbxTiere.Size = new System.Drawing.Size(179, 21);
            this.cbxTiere.TabIndex = 0;
            this.cbxTiere.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // btnNeu
            // 
            this.btnNeu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeu.Location = new System.Drawing.Point(272, 12);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(75, 23);
            this.btnNeu.TabIndex = 1;
            this.btnNeu.Text = "Huhn";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnFuettern
            // 
            this.btnFuettern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuettern.Location = new System.Drawing.Point(272, 124);
            this.btnFuettern.Name = "btnFuettern";
            this.btnFuettern.Size = new System.Drawing.Size(75, 23);
            this.btnFuettern.TabIndex = 2;
            this.btnFuettern.Text = "Füttern";
            this.btnFuettern.UseVisualStyleBackColor = true;
            this.btnFuettern.Click += new System.EventHandler(this.btnFuettern_Click);
            // 
            // btnEiLegen
            // 
            this.btnEiLegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEiLegen.Location = new System.Drawing.Point(272, 153);
            this.btnEiLegen.Name = "btnEiLegen";
            this.btnEiLegen.Size = new System.Drawing.Size(75, 23);
            this.btnEiLegen.TabIndex = 3;
            this.btnEiLegen.Text = "Ei legen";
            this.btnEiLegen.UseVisualStyleBackColor = true;
            this.btnEiLegen.Click += new System.EventHandler(this.btnEiLegen_Click);
            // 
            // pgdTier
            // 
            this.pgdTier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgdTier.Location = new System.Drawing.Point(72, 47);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(179, 224);
            this.pgdTier.TabIndex = 4;
            // 
            // btnSchnabeltier
            // 
            this.btnSchnabeltier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchnabeltier.Location = new System.Drawing.Point(272, 41);
            this.btnSchnabeltier.Name = "btnSchnabeltier";
            this.btnSchnabeltier.Size = new System.Drawing.Size(75, 23);
            this.btnSchnabeltier.TabIndex = 5;
            this.btnSchnabeltier.Text = "Schnabeltier";
            this.btnSchnabeltier.UseVisualStyleBackColor = true;
            this.btnSchnabeltier.Click += new System.EventHandler(this.btnSchnabeltier_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(272, 237);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 6;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(272, 208);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(75, 23);
            this.btnLaden.TabIndex = 7;
            this.btnLaden.Text = "Laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 299);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnSchnabeltier);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.btnEiLegen);
            this.Controls.Add(this.btnFuettern);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.cbxTiere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTiere;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnFuettern;
        private System.Windows.Forms.Button btnEiLegen;
        private System.Windows.Forms.PropertyGrid pgdTier;
        private System.Windows.Forms.Button btnSchnabeltier;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLaden;
    }
}

