namespace TPCSerwer
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
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_poloczeniu = new System.Windows.Forms.ListBox();
            this.przycisk_start = new System.Windows.Forms.Button();
            this.przycisk_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(12, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(396, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(435, 12);
            this.my_port.Maximum = new decimal(new int[] {
            65565,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(389, 20);
            this.my_port.TabIndex = 1;
            // 
            // info_o_poloczeniu
            // 
            this.info_o_poloczeniu.FormattingEnabled = true;
            this.info_o_poloczeniu.Location = new System.Drawing.Point(12, 50);
            this.info_o_poloczeniu.Name = "info_o_poloczeniu";
            this.info_o_poloczeniu.Size = new System.Drawing.Size(800, 225);
            this.info_o_poloczeniu.TabIndex = 2;
            // 
            // przycisk_start
            // 
            this.przycisk_start.Location = new System.Drawing.Point(153, 292);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(199, 72);
            this.przycisk_start.TabIndex = 3;
            this.przycisk_start.Text = "Start";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // przycisk_stop
            // 
            this.przycisk_stop.Location = new System.Drawing.Point(473, 292);
            this.przycisk_stop.Name = "przycisk_stop";
            this.przycisk_stop.Size = new System.Drawing.Size(199, 72);
            this.przycisk_stop.TabIndex = 4;
            this.przycisk_stop.Text = "stop";
            this.przycisk_stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 376);
            this.Controls.Add(this.przycisk_stop);
            this.Controls.Add(this.przycisk_start);
            this.Controls.Add(this.info_o_poloczeniu);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.ListBox info_o_poloczeniu;
        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button przycisk_stop;
    }
}

