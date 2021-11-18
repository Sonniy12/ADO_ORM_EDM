namespace Hero
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Вывод = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Вывод.SuspendLayout();
            this.Добавить.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Добавить);
            this.tabControl1.Controls.Add(this.Вывод);
            this.tabControl1.Location = new System.Drawing.Point(47, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // Вывод
            // 
            this.Вывод.BackgroundImage = global::Hero.Properties.Resources.Фон;
            this.Вывод.Controls.Add(this.button4);
            this.Вывод.Location = new System.Drawing.Point(4, 29);
            this.Вывод.Name = "Вывод";
            this.Вывод.Padding = new System.Windows.Forms.Padding(3);
            this.Вывод.Size = new System.Drawing.Size(733, 414);
            this.Вывод.TabIndex = 1;
            this.Вывод.Text = "Вывод";
            this.Вывод.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(501, 83);
            this.button4.TabIndex = 0;
            this.button4.Text = "Вывод";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Добавить
            // 
            this.Добавить.BackgroundImage = global::Hero.Properties.Resources.Фон;
            this.Добавить.Controls.Add(this.button3);
            this.Добавить.Controls.Add(this.button2);
            this.Добавить.Controls.Add(this.button1);
            this.Добавить.Location = new System.Drawing.Point(4, 29);
            this.Добавить.Name = "Добавить";
            this.Добавить.Padding = new System.Windows.Forms.Padding(3);
            this.Добавить.Size = new System.Drawing.Size(733, 414);
            this.Добавить.TabIndex = 0;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить характеристики";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить героя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(819, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Вывод.ResumeLayout(false);
            this.Добавить.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Добавить;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Вывод;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

