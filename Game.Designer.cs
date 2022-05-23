
namespace FlightChessClient
{
    partial class Game
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.YellowTeam = new System.Windows.Forms.GroupBox();
            this.Chess_y4 = new FlightChessClient.Chess(this.components);
            this.Chess_y2 = new FlightChessClient.Chess(this.components);
            this.Chess_y3 = new FlightChessClient.Chess(this.components);
            this.Chess_y1 = new FlightChessClient.Chess(this.components);
            this.GreenTeam = new System.Windows.Forms.GroupBox();
            this.Chess_g4 = new FlightChessClient.Chess(this.components);
            this.Chess_g3 = new FlightChessClient.Chess(this.components);
            this.Chess_g2 = new FlightChessClient.Chess(this.components);
            this.Chess_g1 = new FlightChessClient.Chess(this.components);
            this.BlueTeam = new System.Windows.Forms.GroupBox();
            this.Chess_b4 = new FlightChessClient.Chess(this.components);
            this.Chess_b3 = new FlightChessClient.Chess(this.components);
            this.Chess_b2 = new FlightChessClient.Chess(this.components);
            this.Chess_b1 = new FlightChessClient.Chess(this.components);
            this.RedTeam = new System.Windows.Forms.GroupBox();
            this.Chess_r4 = new FlightChessClient.Chess(this.components);
            this.Chess_r3 = new FlightChessClient.Chess(this.components);
            this.Chess_r2 = new FlightChessClient.Chess(this.components);
            this.Chess_r1 = new FlightChessClient.Chess(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameInfo = new System.Windows.Forms.Label();
            this.YellowDice = new System.Windows.Forms.Button();
            this.BlueDice = new System.Windows.Forms.Button();
            this.GreenDice = new System.Windows.Forms.Button();
            this.RedDice = new System.Windows.Forms.Button();
            this.YellowTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y1)).BeginInit();
            this.GreenTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g1)).BeginInit();
            this.BlueTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b1)).BeginInit();
            this.RedTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // YellowTeam
            // 
            this.YellowTeam.BackColor = System.Drawing.Color.Khaki;
            this.YellowTeam.Controls.Add(this.Chess_y4);
            this.YellowTeam.Controls.Add(this.Chess_y2);
            this.YellowTeam.Controls.Add(this.Chess_y3);
            this.YellowTeam.Controls.Add(this.Chess_y1);
            this.YellowTeam.Font = new System.Drawing.Font("宋体", 12F);
            this.YellowTeam.Location = new System.Drawing.Point(12, 12);
            this.YellowTeam.Name = "YellowTeam";
            this.YellowTeam.Size = new System.Drawing.Size(192, 174);
            this.YellowTeam.TabIndex = 2;
            this.YellowTeam.TabStop = false;
            this.YellowTeam.Text = "groupBox1";
            // 
            // Chess_y4
            // 
            this.Chess_y4.BackColor = System.Drawing.Color.Transparent;
            this.Chess_y4.Image = global::FlightChessClient.Properties.Resources.chessY1;
            this.Chess_y4.Location = new System.Drawing.Point(110, 99);
            this.Chess_y4.Name = "Chess_y4";
            this.Chess_y4.Size = new System.Drawing.Size(76, 69);
            this.Chess_y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_y4.TabIndex = 5;
            this.Chess_y4.TabStop = false;
            this.Chess_y4.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_y2
            // 
            this.Chess_y2.BackColor = System.Drawing.Color.Transparent;
            this.Chess_y2.Image = global::FlightChessClient.Properties.Resources.chessY1;
            this.Chess_y2.Location = new System.Drawing.Point(110, 20);
            this.Chess_y2.Name = "Chess_y2";
            this.Chess_y2.Size = new System.Drawing.Size(76, 69);
            this.Chess_y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_y2.TabIndex = 4;
            this.Chess_y2.TabStop = false;
            this.Chess_y2.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_y3
            // 
            this.Chess_y3.BackColor = System.Drawing.Color.Transparent;
            this.Chess_y3.Image = global::FlightChessClient.Properties.Resources.chessY1;
            this.Chess_y3.Location = new System.Drawing.Point(6, 99);
            this.Chess_y3.Name = "Chess_y3";
            this.Chess_y3.Size = new System.Drawing.Size(76, 69);
            this.Chess_y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_y3.TabIndex = 3;
            this.Chess_y3.TabStop = false;
            this.Chess_y3.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_y1
            // 
            this.Chess_y1.BackColor = System.Drawing.Color.Transparent;
            this.Chess_y1.Image = global::FlightChessClient.Properties.Resources.chessY1;
            this.Chess_y1.Location = new System.Drawing.Point(6, 20);
            this.Chess_y1.Name = "Chess_y1";
            this.Chess_y1.Size = new System.Drawing.Size(76, 69);
            this.Chess_y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_y1.TabIndex = 2;
            this.Chess_y1.TabStop = false;
            this.Chess_y1.Click += new System.EventHandler(this.Chess_Click);
            // 
            // GreenTeam
            // 
            this.GreenTeam.BackColor = System.Drawing.Color.YellowGreen;
            this.GreenTeam.Controls.Add(this.Chess_g4);
            this.GreenTeam.Controls.Add(this.Chess_g3);
            this.GreenTeam.Controls.Add(this.Chess_g2);
            this.GreenTeam.Controls.Add(this.Chess_g1);
            this.GreenTeam.Font = new System.Drawing.Font("宋体", 12F);
            this.GreenTeam.Location = new System.Drawing.Point(789, 12);
            this.GreenTeam.Name = "GreenTeam";
            this.GreenTeam.Size = new System.Drawing.Size(192, 174);
            this.GreenTeam.TabIndex = 3;
            this.GreenTeam.TabStop = false;
            this.GreenTeam.Text = "groupBox2";
            // 
            // Chess_g4
            // 
            this.Chess_g4.BackColor = System.Drawing.Color.Transparent;
            this.Chess_g4.Image = global::FlightChessClient.Properties.Resources.chessG1;
            this.Chess_g4.Location = new System.Drawing.Point(110, 99);
            this.Chess_g4.Name = "Chess_g4";
            this.Chess_g4.Size = new System.Drawing.Size(76, 69);
            this.Chess_g4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_g4.TabIndex = 4;
            this.Chess_g4.TabStop = false;
            this.Chess_g4.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_g3
            // 
            this.Chess_g3.BackColor = System.Drawing.Color.Transparent;
            this.Chess_g3.Image = global::FlightChessClient.Properties.Resources.chessG1;
            this.Chess_g3.Location = new System.Drawing.Point(6, 99);
            this.Chess_g3.Name = "Chess_g3";
            this.Chess_g3.Size = new System.Drawing.Size(76, 69);
            this.Chess_g3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_g3.TabIndex = 3;
            this.Chess_g3.TabStop = false;
            this.Chess_g3.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_g2
            // 
            this.Chess_g2.BackColor = System.Drawing.Color.Transparent;
            this.Chess_g2.Image = global::FlightChessClient.Properties.Resources.chessG1;
            this.Chess_g2.Location = new System.Drawing.Point(110, 20);
            this.Chess_g2.Name = "Chess_g2";
            this.Chess_g2.Size = new System.Drawing.Size(76, 69);
            this.Chess_g2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_g2.TabIndex = 2;
            this.Chess_g2.TabStop = false;
            this.Chess_g2.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_g1
            // 
            this.Chess_g1.BackColor = System.Drawing.Color.Transparent;
            this.Chess_g1.Image = global::FlightChessClient.Properties.Resources.chessG1;
            this.Chess_g1.Location = new System.Drawing.Point(6, 20);
            this.Chess_g1.Name = "Chess_g1";
            this.Chess_g1.Size = new System.Drawing.Size(76, 69);
            this.Chess_g1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_g1.TabIndex = 1;
            this.Chess_g1.TabStop = false;
            this.Chess_g1.Click += new System.EventHandler(this.Chess_Click);
            // 
            // BlueTeam
            // 
            this.BlueTeam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BlueTeam.Controls.Add(this.Chess_b4);
            this.BlueTeam.Controls.Add(this.Chess_b3);
            this.BlueTeam.Controls.Add(this.Chess_b2);
            this.BlueTeam.Controls.Add(this.Chess_b1);
            this.BlueTeam.Font = new System.Drawing.Font("宋体", 12F);
            this.BlueTeam.Location = new System.Drawing.Point(12, 426);
            this.BlueTeam.Name = "BlueTeam";
            this.BlueTeam.Size = new System.Drawing.Size(192, 174);
            this.BlueTeam.TabIndex = 4;
            this.BlueTeam.TabStop = false;
            this.BlueTeam.Text = "groupBox3";
            // 
            // Chess_b4
            // 
            this.Chess_b4.BackColor = System.Drawing.Color.Transparent;
            this.Chess_b4.Image = global::FlightChessClient.Properties.Resources.chessB1;
            this.Chess_b4.Location = new System.Drawing.Point(110, 100);
            this.Chess_b4.Name = "Chess_b4";
            this.Chess_b4.Size = new System.Drawing.Size(76, 69);
            this.Chess_b4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_b4.TabIndex = 6;
            this.Chess_b4.TabStop = false;
            this.Chess_b4.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_b3
            // 
            this.Chess_b3.BackColor = System.Drawing.Color.Transparent;
            this.Chess_b3.Image = global::FlightChessClient.Properties.Resources.chessB1;
            this.Chess_b3.Location = new System.Drawing.Point(6, 100);
            this.Chess_b3.Name = "Chess_b3";
            this.Chess_b3.Size = new System.Drawing.Size(76, 69);
            this.Chess_b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_b3.TabIndex = 5;
            this.Chess_b3.TabStop = false;
            this.Chess_b3.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_b2
            // 
            this.Chess_b2.BackColor = System.Drawing.Color.Transparent;
            this.Chess_b2.Image = global::FlightChessClient.Properties.Resources.chessB1;
            this.Chess_b2.Location = new System.Drawing.Point(110, 25);
            this.Chess_b2.Name = "Chess_b2";
            this.Chess_b2.Size = new System.Drawing.Size(76, 69);
            this.Chess_b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_b2.TabIndex = 4;
            this.Chess_b2.TabStop = false;
            this.Chess_b2.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_b1
            // 
            this.Chess_b1.BackColor = System.Drawing.Color.Transparent;
            this.Chess_b1.Image = global::FlightChessClient.Properties.Resources.chessB1;
            this.Chess_b1.Location = new System.Drawing.Point(6, 25);
            this.Chess_b1.Name = "Chess_b1";
            this.Chess_b1.Size = new System.Drawing.Size(76, 69);
            this.Chess_b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_b1.TabIndex = 3;
            this.Chess_b1.TabStop = false;
            this.Chess_b1.Click += new System.EventHandler(this.Chess_Click);
            // 
            // RedTeam
            // 
            this.RedTeam.BackColor = System.Drawing.Color.MistyRose;
            this.RedTeam.Controls.Add(this.Chess_r4);
            this.RedTeam.Controls.Add(this.Chess_r3);
            this.RedTeam.Controls.Add(this.Chess_r2);
            this.RedTeam.Controls.Add(this.Chess_r1);
            this.RedTeam.Font = new System.Drawing.Font("宋体", 12F);
            this.RedTeam.Location = new System.Drawing.Point(789, 426);
            this.RedTeam.Name = "RedTeam";
            this.RedTeam.Size = new System.Drawing.Size(192, 174);
            this.RedTeam.TabIndex = 5;
            this.RedTeam.TabStop = false;
            this.RedTeam.Text = "groupBox4";
            // 
            // Chess_r4
            // 
            this.Chess_r4.BackColor = System.Drawing.Color.Transparent;
            this.Chess_r4.Image = global::FlightChessClient.Properties.Resources.chessR1;
            this.Chess_r4.Location = new System.Drawing.Point(110, 99);
            this.Chess_r4.Name = "Chess_r4";
            this.Chess_r4.Size = new System.Drawing.Size(76, 69);
            this.Chess_r4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_r4.TabIndex = 3;
            this.Chess_r4.TabStop = false;
            this.Chess_r4.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_r3
            // 
            this.Chess_r3.BackColor = System.Drawing.Color.Transparent;
            this.Chess_r3.Image = global::FlightChessClient.Properties.Resources.chessR1;
            this.Chess_r3.Location = new System.Drawing.Point(6, 95);
            this.Chess_r3.Name = "Chess_r3";
            this.Chess_r3.Size = new System.Drawing.Size(76, 69);
            this.Chess_r3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_r3.TabIndex = 2;
            this.Chess_r3.TabStop = false;
            this.Chess_r3.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_r2
            // 
            this.Chess_r2.BackColor = System.Drawing.Color.Transparent;
            this.Chess_r2.Image = global::FlightChessClient.Properties.Resources.chessR1;
            this.Chess_r2.Location = new System.Drawing.Point(110, 20);
            this.Chess_r2.Name = "Chess_r2";
            this.Chess_r2.Size = new System.Drawing.Size(76, 69);
            this.Chess_r2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_r2.TabIndex = 1;
            this.Chess_r2.TabStop = false;
            this.Chess_r2.Click += new System.EventHandler(this.Chess_Click);
            // 
            // Chess_r1
            // 
            this.Chess_r1.BackColor = System.Drawing.Color.Transparent;
            this.Chess_r1.Image = global::FlightChessClient.Properties.Resources.chessR1;
            this.Chess_r1.Location = new System.Drawing.Point(6, 20);
            this.Chess_r1.Name = "Chess_r1";
            this.Chess_r1.Size = new System.Drawing.Size(76, 69);
            this.Chess_r1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chess_r1.TabIndex = 0;
            this.Chess_r1.TabStop = false;
            this.Chess_r1.Click += new System.EventHandler(this.Chess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightChessClient.Properties.Resources.飞行棋;
            this.pictureBox1.Location = new System.Drawing.Point(73, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameInfo
            // 
            this.GameInfo.AutoSize = true;
            this.GameInfo.Font = new System.Drawing.Font("宋体", 18F);
            this.GameInfo.Location = new System.Drawing.Point(300, 9);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(106, 24);
            this.GameInfo.TabIndex = 6;
            this.GameInfo.Text = "对战中：";
            // 
            // YellowDice
            // 
            this.YellowDice.BackColor = System.Drawing.Color.Yellow;
            this.YellowDice.Font = new System.Drawing.Font("宋体", 20F);
            this.YellowDice.Location = new System.Drawing.Point(58, 192);
            this.YellowDice.Name = "YellowDice";
            this.YellowDice.Size = new System.Drawing.Size(88, 57);
            this.YellowDice.TabIndex = 7;
            this.YellowDice.Text = "骰子";
            this.YellowDice.UseVisualStyleBackColor = false;
            this.YellowDice.Click += new System.EventHandler(this.YellowDice_Click);
            // 
            // BlueDice
            // 
            this.BlueDice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BlueDice.Font = new System.Drawing.Font("宋体", 20F);
            this.BlueDice.Location = new System.Drawing.Point(58, 363);
            this.BlueDice.Name = "BlueDice";
            this.BlueDice.Size = new System.Drawing.Size(88, 57);
            this.BlueDice.TabIndex = 8;
            this.BlueDice.Text = "骰子";
            this.BlueDice.UseVisualStyleBackColor = false;
            this.BlueDice.Click += new System.EventHandler(this.BlueDice_Click);
            // 
            // GreenDice
            // 
            this.GreenDice.BackColor = System.Drawing.Color.YellowGreen;
            this.GreenDice.Font = new System.Drawing.Font("宋体", 20F);
            this.GreenDice.Location = new System.Drawing.Point(854, 192);
            this.GreenDice.Name = "GreenDice";
            this.GreenDice.Size = new System.Drawing.Size(88, 57);
            this.GreenDice.TabIndex = 9;
            this.GreenDice.Text = "骰子";
            this.GreenDice.UseVisualStyleBackColor = false;
            this.GreenDice.Click += new System.EventHandler(this.GreenDice_Click);
            // 
            // RedDice
            // 
            this.RedDice.BackColor = System.Drawing.Color.Red;
            this.RedDice.Font = new System.Drawing.Font("宋体", 20F);
            this.RedDice.Location = new System.Drawing.Point(854, 363);
            this.RedDice.Name = "RedDice";
            this.RedDice.Size = new System.Drawing.Size(88, 57);
            this.RedDice.TabIndex = 10;
            this.RedDice.Text = "骰子";
            this.RedDice.UseVisualStyleBackColor = false;
            this.RedDice.Click += new System.EventHandler(this.RedDice_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 612);
            this.Controls.Add(this.RedDice);
            this.Controls.Add(this.GreenDice);
            this.Controls.Add(this.BlueDice);
            this.Controls.Add(this.YellowDice);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.RedTeam);
            this.Controls.Add(this.BlueTeam);
            this.Controls.Add(this.GreenTeam);
            this.Controls.Add(this.YellowTeam);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            this.YellowTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_y1)).EndInit();
            this.GreenTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_g1)).EndInit();
            this.BlueTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_b1)).EndInit();
            this.RedTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chess_r1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox YellowTeam;
        private System.Windows.Forms.GroupBox GreenTeam;
        private System.Windows.Forms.GroupBox BlueTeam;
        private System.Windows.Forms.GroupBox RedTeam;
        private Chess Chess_r1;
        private Chess Chess_y4;
        private Chess Chess_y2;
        private Chess Chess_y3;
        private Chess Chess_y1;
        private Chess Chess_g4;
        private Chess Chess_g3;
        private Chess Chess_g2;
        private Chess Chess_g1;
        private Chess Chess_b4;
        private Chess Chess_b3;
        private Chess Chess_b2;
        private Chess Chess_b1;
        private Chess Chess_r4;
        private Chess Chess_r3;
        private Chess Chess_r2;
        private System.Windows.Forms.Label GameInfo;
        private System.Windows.Forms.Button YellowDice;
        private System.Windows.Forms.Button BlueDice;
        private System.Windows.Forms.Button GreenDice;
        private System.Windows.Forms.Button RedDice;
    }
}