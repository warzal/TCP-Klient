namespace TCP_Klient
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.Polacz = new System.Windows.Forms.Button();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adres.Location = new System.Drawing.Point(29, 29);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(312, 21);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            this.Adres.TextChanged += new System.EventHandler(this.Adres_TextChanged);
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.ItemHeight = 15;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(29, 74);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(655, 334);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // Polacz
            // 
            this.Polacz.Location = new System.Drawing.Point(343, 429);
            this.Polacz.Name = "Polacz";
            this.Polacz.Size = new System.Drawing.Size(75, 23);
            this.Polacz.TabIndex = 3;
            this.Polacz.Text = "Polacz";
            this.Polacz.UseVisualStyleBackColor = true;
            this.Polacz.Click += new System.EventHandler(this.button1_Click);
            // 
            // my_port
            // 
            this.my_port.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_port.Location = new System.Drawing.Point(408, 29);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(307, 24);
            this.my_port.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 464);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.Polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button Polacz;
        private System.Windows.Forms.NumericUpDown my_port;
    }
}

