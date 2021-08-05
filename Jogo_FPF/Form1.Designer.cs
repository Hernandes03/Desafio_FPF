namespace Jogo_FPF
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
            this.gb_menus = new System.Windows.Forms.GroupBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_ranking = new System.Windows.Forms.Button();
            this.gb_menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_menus
            // 
            this.gb_menus.Controls.Add(this.bt_start);
            this.gb_menus.Controls.Add(this.bt_home);
            this.gb_menus.Controls.Add(this.bt_ranking);
            this.gb_menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_menus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_menus.Location = new System.Drawing.Point(235, 320);
            this.gb_menus.Name = "gb_menus";
            this.gb_menus.Size = new System.Drawing.Size(317, 130);
            this.gb_menus.TabIndex = 2;
            this.gb_menus.TabStop = false;
            this.gb_menus.Text = "Menus";
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Jogo_FPF.Properties.Resources.logofpf;
            this.pb_logo.Location = new System.Drawing.Point(241, 86);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(311, 237);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.BackgroundImage = global::Jogo_FPF.Properties.Resources.start;
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(216, 26);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(98, 101);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Iniciar Jogo";
            this.bt_start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_home
            // 
            this.bt_home.BackgroundImage = global::Jogo_FPF.Properties.Resources.home;
            this.bt_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_home.Location = new System.Drawing.Point(6, 26);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(99, 101);
            this.bt_home.TabIndex = 0;
            this.bt_home.Text = "Home";
            this.bt_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_ranking
            // 
            this.bt_ranking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ranking.Image = global::Jogo_FPF.Properties.Resources.ranking;
            this.bt_ranking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ranking.Location = new System.Drawing.Point(111, 26);
            this.bt_ranking.Name = "bt_ranking";
            this.bt_ranking.Size = new System.Drawing.Size(99, 101);
            this.bt_ranking.TabIndex = 1;
            this.bt_ranking.Text = "Ranking";
            this.bt_ranking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ranking.UseVisualStyleBackColor = true;
            this.bt_ranking.Click += new System.EventHandler(this.bt_ranking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.gb_menus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo_FPF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_menus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_ranking;
        private System.Windows.Forms.GroupBox gb_menus;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

