
namespace OgrenciEtutKayıt
{
    partial class loginpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpass));
            this.textBoxgiris = new System.Windows.Forms.TextBox();
            this.textBoxcikis = new System.Windows.Forms.TextBox();
            this.buttongiris = new System.Windows.Forms.Button();
            this.buttoncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxgiris
            // 
            this.textBoxgiris.Location = new System.Drawing.Point(306, 217);
            this.textBoxgiris.Name = "textBoxgiris";
            this.textBoxgiris.Size = new System.Drawing.Size(122, 20);
            this.textBoxgiris.TabIndex = 0;
            // 
            // textBoxcikis
            // 
            this.textBoxcikis.Location = new System.Drawing.Point(306, 249);
            this.textBoxcikis.Name = "textBoxcikis";
            this.textBoxcikis.PasswordChar = '*';
            this.textBoxcikis.Size = new System.Drawing.Size(122, 20);
            this.textBoxcikis.TabIndex = 1;
            // 
            // buttongiris
            // 
            this.buttongiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongiris.Location = new System.Drawing.Point(342, 285);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(86, 31);
            this.buttongiris.TabIndex = 2;
            this.buttongiris.Text = "Giriş";
            this.buttongiris.UseVisualStyleBackColor = true;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // buttoncikis
            // 
            this.buttoncikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttoncikis.Location = new System.Drawing.Point(374, 291);
            this.buttoncikis.Name = "buttoncikis";
            this.buttoncikis.Size = new System.Drawing.Size(25, 18);
            this.buttoncikis.TabIndex = 3;
            this.buttoncikis.Text = "Çıkış";
            this.buttoncikis.UseVisualStyleBackColor = true;
            this.buttoncikis.Click += new System.EventHandler(this.buttoncikis_Click);
            // 
            // loginpass
            // 
            this.AcceptButton = this.buttongiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttoncikis;
            this.ClientSize = new System.Drawing.Size(676, 548);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.textBoxcikis);
            this.Controls.Add(this.textBoxgiris);
            this.Controls.Add(this.buttoncikis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginpass";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.loginpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxgiris;
        private System.Windows.Forms.TextBox textBoxcikis;
        private System.Windows.Forms.Button buttongiris;
        private System.Windows.Forms.Button buttoncikis;
    }
}