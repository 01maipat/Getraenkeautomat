namespace Getränkeautomat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Preis = new System.Windows.Forms.Label();
            this.pb_cola = new System.Windows.Forms.PictureBox();
            this.pb_fanta = new System.Windows.Forms.PictureBox();
            this.pb_icetea = new System.Windows.Forms.PictureBox();
            this.pb_spezi = new System.Windows.Forms.PictureBox();
            this.pb_sprite = new System.Windows.Forms.PictureBox();
            this.pb_water = new System.Windows.Forms.PictureBox();
            this.lbl_fanta = new System.Windows.Forms.Label();
            this.lbl_icetea = new System.Windows.Forms.Label();
            this.lbl_spezi = new System.Windows.Forms.Label();
            this.lbl_sprite = new System.Windows.Forms.Label();
            this.lbl_water = new System.Windows.Forms.Label();
            this.lbl_cola = new System.Windows.Forms.Label();
            this.lbl_kontostand = new System.Windows.Forms.Label();
            this.btn_20c = new System.Windows.Forms.Button();
            this.btn_100c = new System.Windows.Forms.Button();
            this.btn_200c = new System.Windows.Forms.Button();
            this.btn_50c = new System.Windows.Forms.Button();
            this.btn_5c = new System.Windows.Forms.Button();
            this.btn_10c = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icetea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_spezi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_water)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Preis
            // 
            this.lbl_Preis.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Preis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preis.Location = new System.Drawing.Point(180, 232);
            this.lbl_Preis.Name = "lbl_Preis";
            this.lbl_Preis.Size = new System.Drawing.Size(129, 54);
            this.lbl_Preis.TabIndex = 0;
            this.lbl_Preis.Click += new System.EventHandler(this.lbl_Preis_Click);
            // 
            // pb_cola
            // 
            this.pb_cola.Image = ((System.Drawing.Image)(resources.GetObject("pb_cola.Image")));
            this.pb_cola.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_cola.InitialImage")));
            this.pb_cola.Location = new System.Drawing.Point(12, 107);
            this.pb_cola.Name = "pb_cola";
            this.pb_cola.Size = new System.Drawing.Size(100, 50);
            this.pb_cola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cola.TabIndex = 1;
            this.pb_cola.TabStop = false;
            this.pb_cola.Click += new System.EventHandler(this.pb_cola_Click);
            this.pb_cola.DoubleClick += new System.EventHandler(this.pb_cola_DoubleClick);
            // 
            // pb_fanta
            // 
            this.pb_fanta.Image = ((System.Drawing.Image)(resources.GetObject("pb_fanta.Image")));
            this.pb_fanta.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_fanta.InitialImage")));
            this.pb_fanta.Location = new System.Drawing.Point(12, 163);
            this.pb_fanta.Name = "pb_fanta";
            this.pb_fanta.Size = new System.Drawing.Size(100, 50);
            this.pb_fanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_fanta.TabIndex = 2;
            this.pb_fanta.TabStop = false;
            this.pb_fanta.Click += new System.EventHandler(this.pb_fanta_Click);
            this.pb_fanta.DoubleClick += new System.EventHandler(this.pb_fanta_DoubleClick);
            // 
            // pb_icetea
            // 
            this.pb_icetea.Image = ((System.Drawing.Image)(resources.GetObject("pb_icetea.Image")));
            this.pb_icetea.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_icetea.InitialImage")));
            this.pb_icetea.Location = new System.Drawing.Point(12, 219);
            this.pb_icetea.Name = "pb_icetea";
            this.pb_icetea.Size = new System.Drawing.Size(100, 50);
            this.pb_icetea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icetea.TabIndex = 3;
            this.pb_icetea.TabStop = false;
            this.pb_icetea.Click += new System.EventHandler(this.pb_icetea_Click);
            this.pb_icetea.DoubleClick += new System.EventHandler(this.pb_icetea_DoubleClick);
            // 
            // pb_spezi
            // 
            this.pb_spezi.Image = ((System.Drawing.Image)(resources.GetObject("pb_spezi.Image")));
            this.pb_spezi.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_spezi.InitialImage")));
            this.pb_spezi.Location = new System.Drawing.Point(12, 275);
            this.pb_spezi.Name = "pb_spezi";
            this.pb_spezi.Size = new System.Drawing.Size(100, 50);
            this.pb_spezi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_spezi.TabIndex = 4;
            this.pb_spezi.TabStop = false;
            this.pb_spezi.Click += new System.EventHandler(this.pb_spezi_Click);
            this.pb_spezi.DoubleClick += new System.EventHandler(this.pb_spezi_DoubleClick);
            // 
            // pb_sprite
            // 
            this.pb_sprite.Image = ((System.Drawing.Image)(resources.GetObject("pb_sprite.Image")));
            this.pb_sprite.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_sprite.InitialImage")));
            this.pb_sprite.Location = new System.Drawing.Point(12, 331);
            this.pb_sprite.Name = "pb_sprite";
            this.pb_sprite.Size = new System.Drawing.Size(100, 50);
            this.pb_sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sprite.TabIndex = 5;
            this.pb_sprite.TabStop = false;
            this.pb_sprite.Click += new System.EventHandler(this.pb_sprite_Click);
            this.pb_sprite.DoubleClick += new System.EventHandler(this.pb_sprite_DoubleClick);
            // 
            // pb_water
            // 
            this.pb_water.Image = ((System.Drawing.Image)(resources.GetObject("pb_water.Image")));
            this.pb_water.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_water.InitialImage")));
            this.pb_water.Location = new System.Drawing.Point(12, 387);
            this.pb_water.Name = "pb_water";
            this.pb_water.Size = new System.Drawing.Size(100, 50);
            this.pb_water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_water.TabIndex = 6;
            this.pb_water.TabStop = false;
            this.pb_water.Click += new System.EventHandler(this.pb_water_Click);
            this.pb_water.DoubleClick += new System.EventHandler(this.pb_water_DoubleClick);
            // 
            // lbl_fanta
            // 
            this.lbl_fanta.BackColor = System.Drawing.Color.Lime;
            this.lbl_fanta.Location = new System.Drawing.Point(118, 175);
            this.lbl_fanta.Name = "lbl_fanta";
            this.lbl_fanta.Size = new System.Drawing.Size(35, 28);
            this.lbl_fanta.TabIndex = 8;
            this.lbl_fanta.Click += new System.EventHandler(this.lbl_fanta_Click);
            // 
            // lbl_icetea
            // 
            this.lbl_icetea.BackColor = System.Drawing.Color.Lime;
            this.lbl_icetea.Location = new System.Drawing.Point(118, 232);
            this.lbl_icetea.Name = "lbl_icetea";
            this.lbl_icetea.Size = new System.Drawing.Size(35, 27);
            this.lbl_icetea.TabIndex = 9;
            this.lbl_icetea.Click += new System.EventHandler(this.lbl_icetea_Click);
            // 
            // lbl_spezi
            // 
            this.lbl_spezi.BackColor = System.Drawing.Color.Lime;
            this.lbl_spezi.Location = new System.Drawing.Point(118, 288);
            this.lbl_spezi.Name = "lbl_spezi";
            this.lbl_spezi.Size = new System.Drawing.Size(35, 27);
            this.lbl_spezi.TabIndex = 10;
            this.lbl_spezi.Click += new System.EventHandler(this.lbl_spezi_Click);
            // 
            // lbl_sprite
            // 
            this.lbl_sprite.BackColor = System.Drawing.Color.Lime;
            this.lbl_sprite.Location = new System.Drawing.Point(118, 341);
            this.lbl_sprite.Name = "lbl_sprite";
            this.lbl_sprite.Size = new System.Drawing.Size(35, 31);
            this.lbl_sprite.TabIndex = 11;
            this.lbl_sprite.Click += new System.EventHandler(this.lbl_sprite_Click);
            // 
            // lbl_water
            // 
            this.lbl_water.BackColor = System.Drawing.Color.Lime;
            this.lbl_water.Location = new System.Drawing.Point(118, 398);
            this.lbl_water.Name = "lbl_water";
            this.lbl_water.Size = new System.Drawing.Size(35, 30);
            this.lbl_water.TabIndex = 12;
            this.lbl_water.Click += new System.EventHandler(this.lbl_water_Click);
            // 
            // lbl_cola
            // 
            this.lbl_cola.BackColor = System.Drawing.Color.Lime;
            this.lbl_cola.Location = new System.Drawing.Point(118, 119);
            this.lbl_cola.Name = "lbl_cola";
            this.lbl_cola.Size = new System.Drawing.Size(35, 29);
            this.lbl_cola.TabIndex = 13;
            this.lbl_cola.Click += new System.EventHandler(this.lbl_cola_Click);
            // 
            // lbl_kontostand
            // 
            this.lbl_kontostand.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_kontostand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kontostand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_kontostand.Location = new System.Drawing.Point(182, 190);
            this.lbl_kontostand.Name = "lbl_kontostand";
            this.lbl_kontostand.Size = new System.Drawing.Size(127, 23);
            this.lbl_kontostand.TabIndex = 14;
            this.lbl_kontostand.Text = "Kontostand = 0€";
            this.lbl_kontostand.Click += new System.EventHandler(this.lbl_kontostand_Click);
            // 
            // btn_20c
            // 
            this.btn_20c.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_20c.Location = new System.Drawing.Point(279, 12);
            this.btn_20c.Name = "btn_20c";
            this.btn_20c.Size = new System.Drawing.Size(30, 30);
            this.btn_20c.TabIndex = 15;
            this.btn_20c.Text = "20c";
            this.btn_20c.UseVisualStyleBackColor = true;
            this.btn_20c.Click += new System.EventHandler(this.btn_20c_Click);
            // 
            // btn_100c
            // 
            this.btn_100c.Location = new System.Drawing.Point(243, 48);
            this.btn_100c.Name = "btn_100c";
            this.btn_100c.Size = new System.Drawing.Size(30, 30);
            this.btn_100c.TabIndex = 16;
            this.btn_100c.Text = "1€";
            this.btn_100c.UseVisualStyleBackColor = true;
            this.btn_100c.Click += new System.EventHandler(this.btn_100c_Click);
            // 
            // btn_200c
            // 
            this.btn_200c.Location = new System.Drawing.Point(279, 48);
            this.btn_200c.Name = "btn_200c";
            this.btn_200c.Size = new System.Drawing.Size(30, 30);
            this.btn_200c.TabIndex = 17;
            this.btn_200c.Text = "2€";
            this.btn_200c.UseVisualStyleBackColor = true;
            this.btn_200c.Click += new System.EventHandler(this.btn_200c_Click);
            // 
            // btn_50c
            // 
            this.btn_50c.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50c.Location = new System.Drawing.Point(207, 48);
            this.btn_50c.Name = "btn_50c";
            this.btn_50c.Size = new System.Drawing.Size(30, 30);
            this.btn_50c.TabIndex = 18;
            this.btn_50c.Text = "50c";
            this.btn_50c.UseVisualStyleBackColor = true;
            this.btn_50c.Click += new System.EventHandler(this.btn_50c_Click);
            // 
            // btn_5c
            // 
            this.btn_5c.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5c.Location = new System.Drawing.Point(207, 12);
            this.btn_5c.Name = "btn_5c";
            this.btn_5c.Size = new System.Drawing.Size(30, 30);
            this.btn_5c.TabIndex = 19;
            this.btn_5c.Text = "5c";
            this.btn_5c.UseVisualStyleBackColor = true;
            this.btn_5c.Click += new System.EventHandler(this.btn_5c_Click);
            // 
            // btn_10c
            // 
            this.btn_10c.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10c.Location = new System.Drawing.Point(243, 12);
            this.btn_10c.Name = "btn_10c";
            this.btn_10c.Size = new System.Drawing.Size(30, 30);
            this.btn_10c.TabIndex = 20;
            this.btn_10c.Text = "10c";
            this.btn_10c.UseVisualStyleBackColor = true;
            this.btn_10c.Click += new System.EventHandler(this.btn_10c_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(321, 522);
            this.Controls.Add(this.btn_10c);
            this.Controls.Add(this.btn_5c);
            this.Controls.Add(this.btn_50c);
            this.Controls.Add(this.btn_200c);
            this.Controls.Add(this.btn_100c);
            this.Controls.Add(this.btn_20c);
            this.Controls.Add(this.lbl_kontostand);
            this.Controls.Add(this.lbl_cola);
            this.Controls.Add(this.lbl_water);
            this.Controls.Add(this.lbl_sprite);
            this.Controls.Add(this.lbl_spezi);
            this.Controls.Add(this.lbl_icetea);
            this.Controls.Add(this.lbl_fanta);
            this.Controls.Add(this.pb_water);
            this.Controls.Add(this.pb_sprite);
            this.Controls.Add(this.pb_spezi);
            this.Controls.Add(this.pb_icetea);
            this.Controls.Add(this.pb_fanta);
            this.Controls.Add(this.pb_cola);
            this.Controls.Add(this.lbl_Preis);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_cola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icetea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_spezi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_water)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Preis;
        private System.Windows.Forms.PictureBox pb_cola;
        private System.Windows.Forms.PictureBox pb_fanta;
        private System.Windows.Forms.PictureBox pb_icetea;
        private System.Windows.Forms.PictureBox pb_spezi;
        private System.Windows.Forms.PictureBox pb_sprite;
        private System.Windows.Forms.PictureBox pb_water;
        private System.Windows.Forms.Label lbl_fanta;
        private System.Windows.Forms.Label lbl_icetea;
        private System.Windows.Forms.Label lbl_spezi;
        private System.Windows.Forms.Label lbl_sprite;
        private System.Windows.Forms.Label lbl_water;
        private System.Windows.Forms.Label lbl_cola;
        private System.Windows.Forms.Label lbl_kontostand;
        private System.Windows.Forms.Button btn_20c;
        private System.Windows.Forms.Button btn_100c;
        private System.Windows.Forms.Button btn_200c;
        private System.Windows.Forms.Button btn_50c;
        private System.Windows.Forms.Button btn_5c;
        private System.Windows.Forms.Button btn_10c;
    }
}

