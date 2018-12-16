namespace HarcosokApplication
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
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.letrehoz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KepessegNev = new System.Windows.Forms.TextBox();
            this.KepessegLeiras = new System.Windows.Forms.TextBox();
            this.KepessegHasznaloja = new System.Windows.Forms.ComboBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modositas = new System.Windows.Forms.Button();
            this.Torles = new System.Windows.Forms.Button();
            this.KepessegText = new System.Windows.Forms.TextBox();
            this.KepessegekLista = new System.Windows.Forms.ListBox();
            this.HarcosokLista = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcos létrehozása";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(62, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(196, 26);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // letrehoz
            // 
            this.letrehoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letrehoz.Location = new System.Drawing.Point(279, 49);
            this.letrehoz.Name = "letrehoz";
            this.letrehoz.Size = new System.Drawing.Size(127, 32);
            this.letrehoz.TabIndex = 3;
            this.letrehoz.Text = "Létrehozás";
            this.letrehoz.UseVisualStyleBackColor = true;
            this.letrehoz.Click += new System.EventHandler(this.letrehoz_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.letrehoz);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KepessegNev);
            this.panel2.Controls.Add(this.KepessegLeiras);
            this.panel2.Controls.Add(this.KepessegHasznaloja);
            this.panel2.Controls.Add(this.hozzaad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 152);
            this.panel2.TabIndex = 5;
            // 
            // KepessegNev
            // 
            this.KepessegNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KepessegNev.Location = new System.Drawing.Point(134, 68);
            this.KepessegNev.Name = "KepessegNev";
            this.KepessegNev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KepessegNev.Size = new System.Drawing.Size(209, 26);
            this.KepessegNev.TabIndex = 4;
            // 
            // KepessegLeiras
            // 
            this.KepessegLeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KepessegLeiras.Location = new System.Drawing.Point(374, 34);
            this.KepessegLeiras.MinimumSize = new System.Drawing.Size(4, 100);
            this.KepessegLeiras.Multiline = true;
            this.KepessegLeiras.Name = "KepessegLeiras";
            this.KepessegLeiras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KepessegLeiras.Size = new System.Drawing.Size(387, 100);
            this.KepessegLeiras.TabIndex = 7;
            // 
            // KepessegHasznaloja
            // 
            this.KepessegHasznaloja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KepessegHasznaloja.FormattingEnabled = true;
            this.KepessegHasznaloja.Location = new System.Drawing.Point(134, 34);
            this.KepessegHasznaloja.Name = "KepessegHasznaloja";
            this.KepessegHasznaloja.Size = new System.Drawing.Size(209, 28);
            this.KepessegHasznaloja.TabIndex = 6;
            // 
            // hozzaad
            // 
            this.hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaad.Location = new System.Drawing.Point(8, 109);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(108, 37);
            this.hozzaad.TabIndex = 4;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(369, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Leírás:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Használó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Képesség hozzáadása";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.modositas);
            this.panel3.Controls.Add(this.Torles);
            this.panel3.Controls.Add(this.KepessegText);
            this.panel3.Controls.Add(this.KepessegekLista);
            this.panel3.Controls.Add(this.HarcosokLista);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 314);
            this.panel3.TabIndex = 6;
            // 
            // modositas
            // 
            this.modositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modositas.Location = new System.Drawing.Point(615, 266);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(146, 31);
            this.modositas.TabIndex = 10;
            this.modositas.Text = "Módosítás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // Torles
            // 
            this.Torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Torles.Location = new System.Drawing.Point(211, 266);
            this.Torles.Name = "Torles";
            this.Torles.Size = new System.Drawing.Size(102, 31);
            this.Torles.TabIndex = 9;
            this.Torles.Text = "Törlés";
            this.Torles.UseVisualStyleBackColor = true;
            this.Torles.Click += new System.EventHandler(this.Torles_Click);
            // 
            // KepessegText
            // 
            this.KepessegText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KepessegText.Location = new System.Drawing.Point(374, 50);
            this.KepessegText.MinimumSize = new System.Drawing.Size(4, 100);
            this.KepessegText.Multiline = true;
            this.KepessegText.Name = "KepessegText";
            this.KepessegText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KepessegText.Size = new System.Drawing.Size(387, 199);
            this.KepessegText.TabIndex = 8;
            // 
            // KepessegekLista
            // 
            this.KepessegekLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KepessegekLista.FormattingEnabled = true;
            this.KepessegekLista.ItemHeight = 15;
            this.KepessegekLista.Location = new System.Drawing.Point(178, 50);
            this.KepessegekLista.Name = "KepessegekLista";
            this.KepessegekLista.Size = new System.Drawing.Size(165, 199);
            this.KepessegekLista.TabIndex = 6;
            this.KepessegekLista.SelectedIndexChanged += new System.EventHandler(this.KepessegekLista_SelectedIndexChanged);
            // 
            // HarcosokLista
            // 
            this.HarcosokLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HarcosokLista.FormattingEnabled = true;
            this.HarcosokLista.ItemHeight = 15;
            this.HarcosokLista.Location = new System.Drawing.Point(8, 50);
            this.HarcosokLista.Name = "HarcosokLista";
            this.HarcosokLista.Size = new System.Drawing.Size(152, 199);
            this.HarcosokLista.TabIndex = 5;
            this.HarcosokLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HarcosokLista_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(369, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Képességek leírása";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(173, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Képességek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Harcosok:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button letrehoz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.TextBox KepessegLeiras;
        private System.Windows.Forms.ComboBox KepessegHasznaloja;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox KepessegText;
        private System.Windows.Forms.ListBox KepessegekLista;
        private System.Windows.Forms.ListBox HarcosokLista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button Torles;
        private System.Windows.Forms.TextBox KepessegNev;
    }
}

