
namespace FlightChessClient
{
    partial class registerF
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
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RePassWordBox = new System.Windows.Forms.TextBox();
            this.register_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("宋体", 12F);
            this.UserNameBox.Location = new System.Drawing.Point(97, 74);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(137, 26);
            this.UserNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // PassWordBox
            // 
            this.PassWordBox.Font = new System.Drawing.Font("宋体", 12F);
            this.PassWordBox.Location = new System.Drawing.Point(97, 128);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.PasswordChar = '●';
            this.PassWordBox.Size = new System.Drawing.Size(137, 26);
            this.PassWordBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(22, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "重复密码";
            // 
            // RePassWordBox
            // 
            this.RePassWordBox.Font = new System.Drawing.Font("宋体", 12F);
            this.RePassWordBox.Location = new System.Drawing.Point(97, 181);
            this.RePassWordBox.Name = "RePassWordBox";
            this.RePassWordBox.PasswordChar = '●';
            this.RePassWordBox.Size = new System.Drawing.Size(137, 26);
            this.RePassWordBox.TabIndex = 4;
            // 
            // register_b
            // 
            this.register_b.Font = new System.Drawing.Font("宋体", 12F);
            this.register_b.Location = new System.Drawing.Point(97, 331);
            this.register_b.Name = "register_b";
            this.register_b.Size = new System.Drawing.Size(75, 23);
            this.register_b.TabIndex = 6;
            this.register_b.Text = "注册";
            this.register_b.UseVisualStyleBackColor = true;
            this.register_b.Click += new System.EventHandler(this.register_b_Click);
            // 
            // registerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 510);
            this.Controls.Add(this.register_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RePassWordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameBox);
            this.Name = "registerF";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RePassWordBox;
        private System.Windows.Forms.Button register_b;
    }
}