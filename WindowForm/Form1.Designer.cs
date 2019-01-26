namespace WindowForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DislikesListBox = new System.Windows.Forms.ListBox();
            this.LikesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateRateButton = new System.Windows.Forms.Button();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.RateablesListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TopTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RecommendedTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.DislikesListBox);
            this.groupBox1.Controls.Add(this.LikesListBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мои данные";
            // 
            // DislikesListBox
            // 
            this.DislikesListBox.FormattingEnabled = true;
            this.DislikesListBox.Location = new System.Drawing.Point(105, 101);
            this.DislikesListBox.Name = "DislikesListBox";
            this.DislikesListBox.Size = new System.Drawing.Size(120, 30);
            this.DislikesListBox.TabIndex = 5;
            // 
            // LikesListBox
            // 
            this.LikesListBox.FormattingEnabled = true;
            this.LikesListBox.Location = new System.Drawing.Point(105, 56);
            this.LikesListBox.Name = "LikesListBox";
            this.LikesListBox.Size = new System.Drawing.Size(120, 30);
            this.LikesListBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Мне не нравится";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Мне нравится";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Мое имя";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.RateTextBox);
            this.groupBox2.Controls.Add(this.UpdateRateButton);
            this.groupBox2.Controls.Add(this.RateablesListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мои впечатления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Мой рейтинг";
            // 
            // UpdateRateButton
            // 
            this.UpdateRateButton.Location = new System.Drawing.Point(124, 92);
            this.UpdateRateButton.Name = "UpdateRateButton";
            this.UpdateRateButton.Size = new System.Drawing.Size(101, 25);
            this.UpdateRateButton.TabIndex = 2;
            this.UpdateRateButton.Text = "Отправить";
            this.UpdateRateButton.UseVisualStyleBackColor = true;
            this.UpdateRateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(124, 57);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(101, 20);
            this.RateTextBox.TabIndex = 1;
            // 
            // RateablesListBox
            // 
            this.RateablesListBox.FormattingEnabled = true;
            this.RateablesListBox.Location = new System.Drawing.Point(9, 35);
            this.RateablesListBox.Name = "RateablesListBox";
            this.RateablesListBox.Size = new System.Drawing.Size(103, 82);
            this.RateablesListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TopTextBox);
            this.groupBox3.Location = new System.Drawing.Point(265, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 140);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Топ лучших";
            // 
            // TopTextBox
            // 
            this.TopTextBox.Location = new System.Drawing.Point(6, 19);
            this.TopTextBox.Multiline = true;
            this.TopTextBox.Name = "TopTextBox";
            this.TopTextBox.Size = new System.Drawing.Size(139, 112);
            this.TopTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RecommendedTextBox);
            this.groupBox4.Location = new System.Drawing.Point(265, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 149);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рекомендации для Вас";
            // 
            // RecommendedTextBox
            // 
            this.RecommendedTextBox.Location = new System.Drawing.Point(6, 19);
            this.RecommendedTextBox.Multiline = true;
            this.RecommendedTextBox.Name = "RecommendedTextBox";
            this.RecommendedTextBox.Size = new System.Drawing.Size(139, 110);
            this.RecommendedTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 332);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox DislikesListBox;
        private System.Windows.Forms.ListBox LikesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateRateButton;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.ListBox RateablesListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TopTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox RecommendedTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

