namespace WindowsFormsApplication1
{
    partial class form_FizzBuzz
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_status = new System.Windows.Forms.Panel();
            this.lavel_maxCount = new System.Windows.Forms.Label();
            this.textBox_maxCount = new System.Windows.Forms.TextBox();
            this.lavel_5multiple = new System.Windows.Forms.Label();
            this.lavel_3multiple = new System.Windows.Forms.Label();
            this.textBox_5multiple = new System.Windows.Forms.TextBox();
            this.textBox_3multiple = new System.Windows.Forms.TextBox();
            this.button_FizzBuzz = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_status
            // 
            this.panel_status.BackColor = System.Drawing.Color.LightBlue;
            this.panel_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_status.Controls.Add(this.lavel_maxCount);
            this.panel_status.Controls.Add(this.textBox_maxCount);
            this.panel_status.Controls.Add(this.lavel_5multiple);
            this.panel_status.Controls.Add(this.lavel_3multiple);
            this.panel_status.Controls.Add(this.textBox_5multiple);
            this.panel_status.Controls.Add(this.textBox_3multiple);
            this.panel_status.Location = new System.Drawing.Point(12, 12);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(164, 96);
            this.panel_status.TabIndex = 0;
            // 
            // lavel_maxCount
            // 
            this.lavel_maxCount.AutoSize = true;
            this.lavel_maxCount.Location = new System.Drawing.Point(3, 68);
            this.lavel_maxCount.Name = "lavel_maxCount";
            this.lavel_maxCount.Size = new System.Drawing.Size(52, 12);
            this.lavel_maxCount.TabIndex = 3;
            this.lavel_maxCount.Text = "カウント数";
            // 
            // textBox_maxCount
            // 
            this.textBox_maxCount.Location = new System.Drawing.Point(66, 65);
            this.textBox_maxCount.MaxLength = 4;
            this.textBox_maxCount.Name = "textBox_maxCount";
            this.textBox_maxCount.Size = new System.Drawing.Size(91, 19);
            this.textBox_maxCount.TabIndex = 3;
            this.textBox_maxCount.Text = "100";
            this.textBox_maxCount.WordWrap = false;
            // 
            // lavel_5multiple
            // 
            this.lavel_5multiple.AutoSize = true;
            this.lavel_5multiple.Location = new System.Drawing.Point(3, 40);
            this.lavel_5multiple.Name = "lavel_5multiple";
            this.lavel_5multiple.Size = new System.Drawing.Size(57, 12);
            this.lavel_5multiple.TabIndex = 2;
            this.lavel_5multiple.Text = "5の倍数時";
            // 
            // lavel_3multiple
            // 
            this.lavel_3multiple.AutoSize = true;
            this.lavel_3multiple.Location = new System.Drawing.Point(3, 10);
            this.lavel_3multiple.Name = "lavel_3multiple";
            this.lavel_3multiple.Size = new System.Drawing.Size(57, 12);
            this.lavel_3multiple.TabIndex = 0;
            this.lavel_3multiple.Text = "3の倍数時";
            // 
            // textBox_5multiple
            // 
            this.textBox_5multiple.Location = new System.Drawing.Point(66, 37);
            this.textBox_5multiple.MaxLength = 10;
            this.textBox_5multiple.Name = "textBox_5multiple";
            this.textBox_5multiple.Size = new System.Drawing.Size(91, 19);
            this.textBox_5multiple.TabIndex = 2;
            this.textBox_5multiple.Text = "Buzz";
            this.textBox_5multiple.WordWrap = false;
            // 
            // textBox_3multiple
            // 
            this.textBox_3multiple.Location = new System.Drawing.Point(66, 7);
            this.textBox_3multiple.MaxLength = 10;
            this.textBox_3multiple.Name = "textBox_3multiple";
            this.textBox_3multiple.Size = new System.Drawing.Size(91, 19);
            this.textBox_3multiple.TabIndex = 1;
            this.textBox_3multiple.Text = "Fizz";
            this.textBox_3multiple.WordWrap = false;
            // 
            // button_FizzBuzz
            // 
            this.button_FizzBuzz.Location = new System.Drawing.Point(179, 42);
            this.button_FizzBuzz.Name = "button_FizzBuzz";
            this.button_FizzBuzz.Size = new System.Drawing.Size(135, 36);
            this.button_FizzBuzz.TabIndex = 0;
            this.button_FizzBuzz.Text = "実行";
            this.button_FizzBuzz.UseVisualStyleBackColor = true;
            this.button_FizzBuzz.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 114);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_result.Size = new System.Drawing.Size(305, 167);
            this.textBox_result.TabIndex = 5;
            this.textBox_result.TabStop = false;
            // 
            // form_FizzBuzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 292);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_FizzBuzz);
            this.Controls.Add(this.panel_status);
            this.Name = "form_FizzBuzz";
            this.Text = "FizzBuzz問題";
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label lavel_maxCount;
        private System.Windows.Forms.TextBox textBox_maxCount;
        private System.Windows.Forms.Label lavel_5multiple;
        private System.Windows.Forms.Label lavel_3multiple;
        private System.Windows.Forms.TextBox textBox_5multiple;
        private System.Windows.Forms.TextBox textBox_3multiple;
        private System.Windows.Forms.Button button_FizzBuzz;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

