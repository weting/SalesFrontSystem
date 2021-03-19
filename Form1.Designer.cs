
namespace SalesFrontSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbx_userid = new System.Windows.Forms.TextBox();
            this.txtbx_account = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "密碼";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_password);
            this.groupBox1.Controls.Add(this.txtbx_account);
            this.groupBox1.Controls.Add(this.txtbx_userid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtbx_userid
            // 
            this.txtbx_userid.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtbx_userid.Location = new System.Drawing.Point(90, 27);
            this.txtbx_userid.Name = "txtbx_userid";
            this.txtbx_userid.Size = new System.Drawing.Size(100, 28);
            this.txtbx_userid.TabIndex = 3;
            // 
            // txtbx_account
            // 
            this.txtbx_account.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtbx_account.Location = new System.Drawing.Point(90, 73);
            this.txtbx_account.Name = "txtbx_account";
            this.txtbx_account.Size = new System.Drawing.Size(100, 28);
            this.txtbx_account.TabIndex = 4;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtbx_password.Location = new System.Drawing.Point(90, 119);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(100, 28);
            this.txtbx_password.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("新細明體", 15F);
            this.btn_login.Location = new System.Drawing.Point(154, 195);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(81, 33);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 240);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.TextBox txtbx_account;
        private System.Windows.Forms.TextBox txtbx_userid;
        private System.Windows.Forms.Button btn_login;
    }
}

