
namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.p_Bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_Art = new System.Windows.Forms.PictureBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_Volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_track_start = new System.Windows.Forms.Label();
            this.lb_Volume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Play.Location = new System.Drawing.Point(92, 551);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(74, 60);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "▶";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_Preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Preview.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preview.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preview.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Preview.Location = new System.Drawing.Point(12, 551);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(74, 60);
            this.btn_Preview.TabIndex = 2;
            this.btn_Preview.Text = "⏮";
            this.btn_Preview.UseVisualStyleBackColor = false;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Next.Location = new System.Drawing.Point(252, 551);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(74, 60);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "⏭";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Pause.Location = new System.Drawing.Point(172, 551);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(74, 60);
            this.btn_Pause.TabIndex = 4;
            this.btn_Pause.Text = "⏸";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Stop.Location = new System.Drawing.Point(332, 551);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(74, 60);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "⏹";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.Transparent;
            this.btn_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Open.Location = new System.Drawing.Point(412, 551);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(74, 60);
            this.btn_Open.TabIndex = 6;
            this.btn_Open.Text = "📂";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // p_Bar
            // 
            this.p_Bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_Bar.Location = new System.Drawing.Point(72, 527);
            this.p_Bar.Name = "p_Bar";
            this.p_Bar.Size = new System.Drawing.Size(414, 18);
            this.p_Bar.TabIndex = 7;
            this.p_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_Bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.Silver;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 15;
            this.track_list.Location = new System.Drawing.Point(12, 367);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(474, 150);
            this.track_list.TabIndex = 8;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_Art
            // 
            this.pic_Art.Image = global::MusicPlayer.Properties.Resources.Disco;
            this.pic_Art.Location = new System.Drawing.Point(96, 64);
            this.pic_Art.Name = "pic_Art";
            this.pic_Art.Size = new System.Drawing.Size(306, 297);
            this.pic_Art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Art.TabIndex = 9;
            this.pic_Art.TabStop = false;
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(499, 58);
            this.Player.TabIndex = 10;
            // 
            // track_Volume
            // 
            this.track_Volume.Location = new System.Drawing.Point(430, 105);
            this.track_Volume.Maximum = 100;
            this.track_Volume.Name = "track_Volume";
            this.track_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_Volume.Size = new System.Drawing.Size(56, 230);
            this.track_Volume.TabIndex = 11;
            this.track_Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_Volume.Scroll += new System.EventHandler(this.track_Volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "🔉";
            // 
            // lb_track_start
            // 
            this.lb_track_start.AutoSize = true;
            this.lb_track_start.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_track_start.Location = new System.Drawing.Point(12, 527);
            this.lb_track_start.Name = "lb_track_start";
            this.lb_track_start.Size = new System.Drawing.Size(54, 20);
            this.lb_track_start.TabIndex = 13;
            this.lb_track_start.Text = "00:00";
            // 
            // lb_Volume
            // 
            this.lb_Volume.AutoSize = true;
            this.lb_Volume.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_Volume.Location = new System.Drawing.Point(427, 82);
            this.lb_Volume.Name = "lb_Volume";
            this.lb_Volume.Size = new System.Drawing.Size(45, 20);
            this.lb_Volume.TabIndex = 15;
            this.lb_Volume.Text = "100%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(499, 663);
            this.Controls.Add(this.lb_Volume);
            this.Controls.Add(this.lb_track_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_Volume);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pic_Art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.p_Bar);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.btn_Play);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.ProgressBar p_Bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_Art;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TrackBar track_Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_track_start;
        private System.Windows.Forms.Label lb_Volume;
        private System.Windows.Forms.Timer timer1;
    }
}

