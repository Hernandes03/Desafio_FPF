namespace Jogo_FPF
{
    partial class Jogo
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
            this.components = new System.ComponentModel.Container();
            this.lb_VPlayer = new System.Windows.Forms.Label();
            this.pgb_VPlayer = new System.Windows.Forms.ProgressBar();
            this.gb_player = new System.Windows.Forms.GroupBox();
            this.lb_Munição = new System.Windows.Forms.Label();
            this.gb_monstro = new System.Windows.Forms.GroupBox();
            this.lb_VMonstro = new System.Windows.Forms.Label();
            this.pgb_VMonstro = new System.Windows.Forms.ProgressBar();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.T_PlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_Score = new System.Windows.Forms.Label();
            this.gb_player.SuspendLayout();
            this.gb_monstro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_VPlayer
            // 
            this.lb_VPlayer.AutoSize = true;
            this.lb_VPlayer.BackColor = System.Drawing.SystemColors.GrayText;
            this.lb_VPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VPlayer.ForeColor = System.Drawing.Color.White;
            this.lb_VPlayer.Location = new System.Drawing.Point(5, 41);
            this.lb_VPlayer.Name = "lb_VPlayer";
            this.lb_VPlayer.Size = new System.Drawing.Size(40, 16);
            this.lb_VPlayer.TabIndex = 0;
            this.lb_VPlayer.Text = "Vida";
            // 
            // pgb_VPlayer
            // 
            this.pgb_VPlayer.Location = new System.Drawing.Point(51, 36);
            this.pgb_VPlayer.Name = "pgb_VPlayer";
            this.pgb_VPlayer.Size = new System.Drawing.Size(130, 23);
            this.pgb_VPlayer.TabIndex = 1;
            this.pgb_VPlayer.Value = 100;
            // 
            // gb_player
            // 
            this.gb_player.Controls.Add(this.lb_Score);
            this.gb_player.Controls.Add(this.lb_Munição);
            this.gb_player.Controls.Add(this.lb_VPlayer);
            this.gb_player.Controls.Add(this.pgb_VPlayer);
            this.gb_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_player.Location = new System.Drawing.Point(4, 4);
            this.gb_player.Name = "gb_player";
            this.gb_player.Size = new System.Drawing.Size(185, 72);
            this.gb_player.TabIndex = 2;
            this.gb_player.TabStop = false;
            this.gb_player.Text = "Player";
            // 
            // lb_Munição
            // 
            this.lb_Munição.AutoSize = true;
            this.lb_Munição.BackColor = System.Drawing.SystemColors.GrayText;
            this.lb_Munição.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Munição.ForeColor = System.Drawing.Color.White;
            this.lb_Munição.Location = new System.Drawing.Point(48, 17);
            this.lb_Munição.Name = "lb_Munição";
            this.lb_Munição.Size = new System.Drawing.Size(82, 16);
            this.lb_Munição.TabIndex = 2;
            this.lb_Munição.Text = "Munição: 0";
            // 
            // gb_monstro
            // 
            this.gb_monstro.Controls.Add(this.lb_VMonstro);
            this.gb_monstro.Controls.Add(this.pgb_VMonstro);
            this.gb_monstro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_monstro.Location = new System.Drawing.Point(4, 91);
            this.gb_monstro.Name = "gb_monstro";
            this.gb_monstro.Size = new System.Drawing.Size(185, 59);
            this.gb_monstro.TabIndex = 3;
            this.gb_monstro.TabStop = false;
            this.gb_monstro.Text = "Monstro";
            // 
            // lb_VMonstro
            // 
            this.lb_VMonstro.AutoSize = true;
            this.lb_VMonstro.BackColor = System.Drawing.SystemColors.GrayText;
            this.lb_VMonstro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VMonstro.ForeColor = System.Drawing.Color.White;
            this.lb_VMonstro.Location = new System.Drawing.Point(6, 33);
            this.lb_VMonstro.Name = "lb_VMonstro";
            this.lb_VMonstro.Size = new System.Drawing.Size(40, 16);
            this.lb_VMonstro.TabIndex = 0;
            this.lb_VMonstro.Text = "Vida";
            // 
            // pgb_VMonstro
            // 
            this.pgb_VMonstro.Location = new System.Drawing.Point(52, 26);
            this.pgb_VMonstro.Name = "pgb_VMonstro";
            this.pgb_VMonstro.Size = new System.Drawing.Size(130, 23);
            this.pgb_VMonstro.TabIndex = 1;
            this.pgb_VMonstro.Value = 100;
            // 
            // pb_Player
            // 
            this.pb_Player.Image = global::Jogo_FPF.Properties.Resources.up;
            this.pb_Player.Location = new System.Drawing.Point(338, 277);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(71, 100);
            this.pb_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Player.TabIndex = 4;
            this.pb_Player.TabStop = false;
            // 
            // T_PlayerTimer
            // 
            this.T_PlayerTimer.Enabled = true;
            this.T_PlayerTimer.Interval = 20;
            this.T_PlayerTimer.Tick += new System.EventHandler(this.Evento_Pincipal_do_Temporizador);
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.BackColor = System.Drawing.SystemColors.GrayText;
            this.lb_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.ForeColor = System.Drawing.Color.White;
            this.lb_Score.Location = new System.Drawing.Point(129, 17);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(53, 16);
            this.lb_Score.TabIndex = 3;
            this.lb_Score.Text = "Kills: 0";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.gb_monstro);
            this.Controls.Add(this.gb_player);
            this.Name = "Jogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDonw);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.gb_player.ResumeLayout(false);
            this.gb_player.PerformLayout();
            this.gb_monstro.ResumeLayout(false);
            this.gb_monstro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_VPlayer;
        private System.Windows.Forms.ProgressBar pgb_VPlayer;
        private System.Windows.Forms.GroupBox gb_player;
        private System.Windows.Forms.GroupBox gb_monstro;
        private System.Windows.Forms.Label lb_VMonstro;
        private System.Windows.Forms.ProgressBar pgb_VMonstro;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer T_PlayerTimer;
        private System.Windows.Forms.Label lb_Munição;
        private System.Windows.Forms.Label lb_Score;
    }
}