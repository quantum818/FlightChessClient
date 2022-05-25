
namespace FlightChessClient
{
    partial class GameHall
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
            this.ChatRoom = new System.Windows.Forms.TextBox();
            this.MSGBox = new System.Windows.Forms.TextBox();
            this.sendMsg = new System.Windows.Forms.Button();
            this.NameLAB = new System.Windows.Forms.Label();
            this.ClassLAB = new System.Windows.Forms.Label();
            this.ClassGroupLAB = new System.Windows.Forms.Label();
            this.desLAB = new System.Windows.Forms.Label();
            this.personalInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RoomInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatRoom
            // 
            this.ChatRoom.Location = new System.Drawing.Point(756, 12);
            this.ChatRoom.Multiline = true;
            this.ChatRoom.Name = "ChatRoom";
            this.ChatRoom.ReadOnly = true;
            this.ChatRoom.Size = new System.Drawing.Size(233, 304);
            this.ChatRoom.TabIndex = 0;
            // 
            // MSGBox
            // 
            this.MSGBox.Font = new System.Drawing.Font("宋体", 12F);
            this.MSGBox.Location = new System.Drawing.Point(836, 322);
            this.MSGBox.Name = "MSGBox";
            this.MSGBox.Size = new System.Drawing.Size(152, 26);
            this.MSGBox.TabIndex = 1;
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(755, 324);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(75, 23);
            this.sendMsg.TabIndex = 2;
            this.sendMsg.Text = "送信";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // NameLAB
            // 
            this.NameLAB.AutoSize = true;
            this.NameLAB.Font = new System.Drawing.Font("宋体", 12F);
            this.NameLAB.Location = new System.Drawing.Point(12, 118);
            this.NameLAB.Name = "NameLAB";
            this.NameLAB.Size = new System.Drawing.Size(48, 16);
            this.NameLAB.TabIndex = 4;
            this.NameLAB.Text = "昵称:";
            // 
            // ClassLAB
            // 
            this.ClassLAB.AutoSize = true;
            this.ClassLAB.Font = new System.Drawing.Font("宋体", 12F);
            this.ClassLAB.Location = new System.Drawing.Point(12, 134);
            this.ClassLAB.Name = "ClassLAB";
            this.ClassLAB.Size = new System.Drawing.Size(48, 16);
            this.ClassLAB.TabIndex = 5;
            this.ClassLAB.Text = "等级:";
            // 
            // ClassGroupLAB
            // 
            this.ClassGroupLAB.AutoSize = true;
            this.ClassGroupLAB.Font = new System.Drawing.Font("宋体", 12F);
            this.ClassGroupLAB.Location = new System.Drawing.Point(12, 153);
            this.ClassGroupLAB.Name = "ClassGroupLAB";
            this.ClassGroupLAB.Size = new System.Drawing.Size(48, 16);
            this.ClassGroupLAB.TabIndex = 6;
            this.ClassGroupLAB.Text = "称号:";
            // 
            // desLAB
            // 
            this.desLAB.AutoSize = true;
            this.desLAB.Font = new System.Drawing.Font("宋体", 9F);
            this.desLAB.Location = new System.Drawing.Point(13, 169);
            this.desLAB.Name = "desLAB";
            this.desLAB.Size = new System.Drawing.Size(59, 12);
            this.desLAB.TabIndex = 8;
            this.desLAB.Text = "个性签名:";
            // 
            // personalInfo
            // 
            this.personalInfo.Location = new System.Drawing.Point(15, 196);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(75, 23);
            this.personalInfo.TabIndex = 9;
            this.personalInfo.Text = "个人信息";
            this.personalInfo.UseVisualStyleBackColor = true;
            this.personalInfo.Click += new System.EventHandler(this.personalInfo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 24F);
            this.button1.Location = new System.Drawing.Point(188, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 169);
            this.button1.TabIndex = 10;
            this.button1.Text = "房间1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoomInfo
            // 
            this.RoomInfo.Location = new System.Drawing.Point(755, 380);
            this.RoomInfo.Multiline = true;
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.ReadOnly = true;
            this.RoomInfo.Size = new System.Drawing.Size(232, 148);
            this.RoomInfo.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightChessClient.Properties.Resources.pic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerBox
            // 
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.ItemHeight = 12;
            this.PlayerBox.Location = new System.Drawing.Point(12, 296);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(90, 232);
            this.PlayerBox.TabIndex = 12;
            this.PlayerBox.SelectedIndexChanged += new System.EventHandler(this.PlayerBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "在线:";
            // 
            // GameHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.RoomInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personalInfo);
            this.Controls.Add(this.desLAB);
            this.Controls.Add(this.ClassGroupLAB);
            this.Controls.Add(this.ClassLAB);
            this.Controls.Add(this.NameLAB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendMsg);
            this.Controls.Add(this.MSGBox);
            this.Controls.Add(this.ChatRoom);
            this.Name = "GameHall";
            this.Text = "GameHall";
            this.Load += new System.EventHandler(this.GameHall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ChatRoom;
        private System.Windows.Forms.TextBox MSGBox;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLAB;
        private System.Windows.Forms.Label ClassLAB;
        private System.Windows.Forms.Label ClassGroupLAB;
        private System.Windows.Forms.Label desLAB;
        private System.Windows.Forms.Button personalInfo;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox RoomInfo;
        public System.Windows.Forms.ListBox PlayerBox;
        private System.Windows.Forms.Label label1;
    }
}