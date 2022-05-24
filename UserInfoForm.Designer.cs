
namespace FlightChessClient
{
    partial class UserInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreatTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeInfo = new System.Windows.Forms.Button();
            this.SaveInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15F);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("宋体", 12F);
            this.NameBox.Location = new System.Drawing.Point(107, 37);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(135, 26);
            this.NameBox.TabIndex = 1;
            // 
            // ClassBox
            // 
            this.ClassBox.Font = new System.Drawing.Font("宋体", 12F);
            this.ClassBox.Location = new System.Drawing.Point(107, 69);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(135, 26);
            this.ClassBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 15F);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "等级";
            // 
            // ClassNameBox
            // 
            this.ClassNameBox.Font = new System.Drawing.Font("宋体", 12F);
            this.ClassNameBox.Location = new System.Drawing.Point(107, 101);
            this.ClassNameBox.Name = "ClassNameBox";
            this.ClassNameBox.Size = new System.Drawing.Size(135, 26);
            this.ClassNameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 15F);
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "称号";
            // 
            // CreatTime
            // 
            this.CreatTime.Font = new System.Drawing.Font("宋体", 12F);
            this.CreatTime.Location = new System.Drawing.Point(107, 133);
            this.CreatTime.Name = "CreatTime";
            this.CreatTime.Size = new System.Drawing.Size(135, 26);
            this.CreatTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 15F);
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "创建时间";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("宋体", 9F);
            this.descriptionBox.Location = new System.Drawing.Point(107, 165);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(203, 21);
            this.descriptionBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 15F);
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "个性签名";
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeInfo.Location = new System.Drawing.Point(107, 258);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(85, 42);
            this.ChangeInfo.TabIndex = 10;
            this.ChangeInfo.Text = "更改信息";
            this.ChangeInfo.UseVisualStyleBackColor = true;
            this.ChangeInfo.Click += new System.EventHandler(this.ChangeInfo_Click);
            // 
            // SaveInfo
            // 
            this.SaveInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveInfo.Location = new System.Drawing.Point(107, 319);
            this.SaveInfo.Name = "SaveInfo";
            this.SaveInfo.Size = new System.Drawing.Size(85, 42);
            this.SaveInfo.TabIndex = 11;
            this.SaveInfo.Text = "保存";
            this.SaveInfo.UseVisualStyleBackColor = true;
            this.SaveInfo.Click += new System.EventHandler(this.SaveInfo_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 475);
            this.Controls.Add(this.SaveInfo);
            this.Controls.Add(this.ChangeInfo);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreatTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClassNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ClassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreatTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChangeInfo;
        private System.Windows.Forms.Button SaveInfo;
    }
}