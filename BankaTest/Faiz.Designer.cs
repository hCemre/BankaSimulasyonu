namespace BankaTest
{
    partial class Faiz
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
            this.LblAnapara = new System.Windows.Forms.Label();
            this.LblFaizOrani = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.LblFaiz = new System.Windows.Forms.Label();
            this.LblVergi = new System.Windows.Forms.Label();
            this.LblNetFaiz = new System.Windows.Forms.Label();
            this.BtnHesaplaFaiz = new System.Windows.Forms.Button();
            this.TxtAnapara = new System.Windows.Forms.TextBox();
            this.TxtFaizOrani = new System.Windows.Forms.TextBox();
            this.TxtSure = new System.Windows.Forms.TextBox();
            this.TxtFaiz = new System.Windows.Forms.TextBox();
            this.TxtVergi = new System.Windows.Forms.TextBox();
            this.TxtNetFaiz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblAnapara
            // 
            this.LblAnapara.AutoSize = true;
            this.LblAnapara.Location = new System.Drawing.Point(52, 29);
            this.LblAnapara.Name = "LblAnapara";
            this.LblAnapara.Size = new System.Drawing.Size(68, 18);
            this.LblAnapara.TabIndex = 0;
            this.LblAnapara.Text = "Anapara";
            // 
            // LblFaizOrani
            // 
            this.LblFaizOrani.AutoSize = true;
            this.LblFaizOrani.Location = new System.Drawing.Point(51, 64);
            this.LblFaizOrani.Name = "LblFaizOrani";
            this.LblFaizOrani.Size = new System.Drawing.Size(81, 18);
            this.LblFaizOrani.TabIndex = 1;
            this.LblFaizOrani.Text = "Faiz Oranı";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Location = new System.Drawing.Point(52, 104);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(41, 18);
            this.LblSure.TabIndex = 2;
            this.LblSure.Text = "Süre";
            // 
            // LblFaiz
            // 
            this.LblFaiz.AutoSize = true;
            this.LblFaiz.Location = new System.Drawing.Point(51, 216);
            this.LblFaiz.Name = "LblFaiz";
            this.LblFaiz.Size = new System.Drawing.Size(37, 18);
            this.LblFaiz.TabIndex = 3;
            this.LblFaiz.Text = "Faiz";
            // 
            // LblVergi
            // 
            this.LblVergi.AutoSize = true;
            this.LblVergi.Location = new System.Drawing.Point(52, 253);
            this.LblVergi.Name = "LblVergi";
            this.LblVergi.Size = new System.Drawing.Size(46, 18);
            this.LblVergi.TabIndex = 4;
            this.LblVergi.Text = "Vergi";
            // 
            // LblNetFaiz
            // 
            this.LblNetFaiz.AutoSize = true;
            this.LblNetFaiz.Location = new System.Drawing.Point(52, 287);
            this.LblNetFaiz.Name = "LblNetFaiz";
            this.LblNetFaiz.Size = new System.Drawing.Size(67, 18);
            this.LblNetFaiz.TabIndex = 5;
            this.LblNetFaiz.Text = "Net Faiz";
            // 
            // BtnHesaplaFaiz
            // 
            this.BtnHesaplaFaiz.Location = new System.Drawing.Point(175, 155);
            this.BtnHesaplaFaiz.Name = "BtnHesaplaFaiz";
            this.BtnHesaplaFaiz.Size = new System.Drawing.Size(75, 23);
            this.BtnHesaplaFaiz.TabIndex = 6;
            this.BtnHesaplaFaiz.Text = "Hesapla";
            this.BtnHesaplaFaiz.UseVisualStyleBackColor = true;
            this.BtnHesaplaFaiz.Click += new System.EventHandler(this.BtnHesaplaFaiz_Click);
            // 
            // TxtAnapara
            // 
            this.TxtAnapara.Location = new System.Drawing.Point(175, 26);
            this.TxtAnapara.Name = "TxtAnapara";
            this.TxtAnapara.Size = new System.Drawing.Size(100, 26);
            this.TxtAnapara.TabIndex = 7;
            // 
            // TxtFaizOrani
            // 
            this.TxtFaizOrani.Location = new System.Drawing.Point(175, 64);
            this.TxtFaizOrani.Name = "TxtFaizOrani";
            this.TxtFaizOrani.Size = new System.Drawing.Size(100, 26);
            this.TxtFaizOrani.TabIndex = 8;
            // 
            // TxtSure
            // 
            this.TxtSure.Location = new System.Drawing.Point(175, 101);
            this.TxtSure.Name = "TxtSure";
            this.TxtSure.Size = new System.Drawing.Size(100, 26);
            this.TxtSure.TabIndex = 9;
            // 
            // TxtFaiz
            // 
            this.TxtFaiz.Enabled = false;
            this.TxtFaiz.Location = new System.Drawing.Point(150, 213);
            this.TxtFaiz.Name = "TxtFaiz";
            this.TxtFaiz.Size = new System.Drawing.Size(100, 26);
            this.TxtFaiz.TabIndex = 10;
            // 
            // TxtVergi
            // 
            this.TxtVergi.Enabled = false;
            this.TxtVergi.Location = new System.Drawing.Point(150, 250);
            this.TxtVergi.Name = "TxtVergi";
            this.TxtVergi.Size = new System.Drawing.Size(100, 26);
            this.TxtVergi.TabIndex = 11;
            // 
            // TxtNetFaiz
            // 
            this.TxtNetFaiz.Enabled = false;
            this.TxtNetFaiz.Location = new System.Drawing.Point(150, 284);
            this.TxtNetFaiz.Name = "TxtNetFaiz";
            this.TxtNetFaiz.Size = new System.Drawing.Size(100, 26);
            this.TxtNetFaiz.TabIndex = 12;
            // 
            // Faiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(323, 332);
            this.Controls.Add(this.TxtNetFaiz);
            this.Controls.Add(this.TxtVergi);
            this.Controls.Add(this.TxtFaiz);
            this.Controls.Add(this.TxtSure);
            this.Controls.Add(this.TxtFaizOrani);
            this.Controls.Add(this.TxtAnapara);
            this.Controls.Add(this.BtnHesaplaFaiz);
            this.Controls.Add(this.LblNetFaiz);
            this.Controls.Add(this.LblVergi);
            this.Controls.Add(this.LblFaiz);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.LblFaizOrani);
            this.Controls.Add(this.LblAnapara);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Faiz";
            this.Text = "Faiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnapara;
        private System.Windows.Forms.Label LblFaizOrani;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label LblFaiz;
        private System.Windows.Forms.Label LblVergi;
        private System.Windows.Forms.Label LblNetFaiz;
        private System.Windows.Forms.Button BtnHesaplaFaiz;
        private System.Windows.Forms.TextBox TxtAnapara;
        private System.Windows.Forms.TextBox TxtFaizOrani;
        private System.Windows.Forms.TextBox TxtSure;
        private System.Windows.Forms.TextBox TxtFaiz;
        private System.Windows.Forms.TextBox TxtVergi;
        private System.Windows.Forms.TextBox TxtNetFaiz;
    }
}