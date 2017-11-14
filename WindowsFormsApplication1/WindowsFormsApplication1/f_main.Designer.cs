namespace WindowsFormsApplication1
{
    partial class f_main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_入廠建檔 = new System.Windows.Forms.Button();
            this.button_維修資料 = new System.Windows.Forms.Button();
            this.button_請款作業 = new System.Windows.Forms.Button();
            this.button_連結監理站 = new System.Windows.Forms.Button();
            this.button_票據管理 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_離開 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_入廠建檔
            // 
            this.button_入廠建檔.Location = new System.Drawing.Point(12, 12);
            this.button_入廠建檔.Name = "button_入廠建檔";
            this.button_入廠建檔.Size = new System.Drawing.Size(177, 82);
            this.button_入廠建檔.TabIndex = 0;
            this.button_入廠建檔.Text = "入廠建檔";
            this.button_入廠建檔.UseVisualStyleBackColor = true;
            this.button_入廠建檔.Click += new System.EventHandler(this.button_入廠建檔_Click);
            // 
            // button_維修資料
            // 
            this.button_維修資料.Location = new System.Drawing.Point(195, 12);
            this.button_維修資料.Name = "button_維修資料";
            this.button_維修資料.Size = new System.Drawing.Size(177, 82);
            this.button_維修資料.TabIndex = 1;
            this.button_維修資料.Text = "維修資料";
            this.button_維修資料.UseVisualStyleBackColor = true;
            // 
            // button_請款作業
            // 
            this.button_請款作業.Location = new System.Drawing.Point(378, 12);
            this.button_請款作業.Name = "button_請款作業";
            this.button_請款作業.Size = new System.Drawing.Size(177, 82);
            this.button_請款作業.TabIndex = 1;
            this.button_請款作業.Text = "請款作業";
            this.button_請款作業.UseVisualStyleBackColor = true;
            // 
            // button_連結監理站
            // 
            this.button_連結監理站.Location = new System.Drawing.Point(12, 100);
            this.button_連結監理站.Name = "button_連結監理站";
            this.button_連結監理站.Size = new System.Drawing.Size(177, 82);
            this.button_連結監理站.TabIndex = 1;
            this.button_連結監理站.Text = "連結監理站";
            this.button_連結監理站.UseVisualStyleBackColor = true;
            // 
            // button_票據管理
            // 
            this.button_票據管理.Location = new System.Drawing.Point(195, 100);
            this.button_票據管理.Name = "button_票據管理";
            this.button_票據管理.Size = new System.Drawing.Size(177, 82);
            this.button_票據管理.TabIndex = 1;
            this.button_票據管理.Text = "票據管理";
            this.button_票據管理.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 82);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_離開
            // 
            this.button_離開.Location = new System.Drawing.Point(378, 188);
            this.button_離開.Name = "button_離開";
            this.button_離開.Size = new System.Drawing.Size(177, 82);
            this.button_離開.TabIndex = 2;
            this.button_離開.Text = "離開";
            this.button_離開.UseVisualStyleBackColor = true;
            this.button_離開.Click += new System.EventHandler(this.button_離開_Click);
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button_離開);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_票據管理);
            this.Controls.Add(this.button_連結監理站);
            this.Controls.Add(this.button_請款作業);
            this.Controls.Add(this.button_維修資料);
            this.Controls.Add(this.button_入廠建檔);
            this.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "f_main";
            this.Text = "承揚汽車企業社";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_入廠建檔;
        private System.Windows.Forms.Button button_維修資料;
        private System.Windows.Forms.Button button_請款作業;
        private System.Windows.Forms.Button button_連結監理站;
        private System.Windows.Forms.Button button_票據管理;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_離開;
    }
}

