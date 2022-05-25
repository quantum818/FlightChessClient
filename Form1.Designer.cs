
namespace FlightChessClient
{
    partial class Form1
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
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(118, 130);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(186, 21);
            this.UserNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(56, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(56, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // PassWordBox
            // 
            this.PassWordBox.Location = new System.Drawing.Point(118, 168);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.PasswordChar = '●';
            this.PassWordBox.Size = new System.Drawing.Size(186, 21);
            this.PassWordBox.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("宋体", 12F);
            this.Login.Location = new System.Drawing.Point(151, 230);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("宋体", 12F);
            this.register.Location = new System.Drawing.Point(151, 268);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 5;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 388);
            this.Controls.Add(this.register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameBox);
            this.Name = "Form1";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWordBox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button register;
    }
}

