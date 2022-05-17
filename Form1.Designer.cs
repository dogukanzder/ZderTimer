
namespace ZderTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MetinKutusu = new System.Windows.Forms.TextBox();
            this.Baslat = new System.Windows.Forms.Button();
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.Metin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MetinKutusu
            // 
            this.MetinKutusu.BackColor = System.Drawing.SystemColors.Desktop;
            this.MetinKutusu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MetinKutusu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MetinKutusu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MetinKutusu.Location = new System.Drawing.Point(0, 0);
            this.MetinKutusu.Name = "MetinKutusu";
            this.MetinKutusu.Size = new System.Drawing.Size(380, 43);
            this.MetinKutusu.TabIndex = 5;
            this.MetinKutusu.Text = "*14:35";
            this.MetinKutusu.Click += new System.EventHandler(this.MetinKutusu_Click);
            this.MetinKutusu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MetinKutusu_KeyDown);
            this.MetinKutusu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MetinKutusu_KeyPress);
            // 
            // Baslat
            // 
            this.Baslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baslat.ForeColor = System.Drawing.Color.Aquamarine;
            this.Baslat.Location = new System.Drawing.Point(119, 130);
            this.Baslat.Name = "Baslat";
            this.Baslat.Size = new System.Drawing.Size(125, 67);
            this.Baslat.TabIndex = 6;
            this.Baslat.Text = "Başlat";
            this.Baslat.UseVisualStyleBackColor = true;
            this.Baslat.Click += new System.EventHandler(this.Baslat_Click);
            // 
            // Ticker
            // 
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // Metin
            // 
            this.Metin.AutoSize = true;
            this.Metin.Font = new System.Drawing.Font("Yu Gothic Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Metin.Location = new System.Drawing.Point(63, 264);
            this.Metin.Name = "Metin";
            this.Metin.Size = new System.Drawing.Size(227, 44);
            this.Metin.TabIndex = 8;
            this.Metin.Text = "12:34:567890";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this.Metin);
            this.Controls.Add(this.Baslat);
            this.Controls.Add(this.MetinKutusu);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(20, 43);
            this.Name = "Form1";
            this.Text = "ZderTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MetinKutusu;
        private System.Windows.Forms.Button Baslat;
        private System.Windows.Forms.Timer Ticker;
        private System.Windows.Forms.Label Metin;
    }
}

