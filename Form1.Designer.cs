namespace Курсовая_работа
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.mass = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.imt_result = new System.Windows.Forms.Label();
            this.none = new System.Windows.Forms.PictureBox();
            this.thin = new System.Windows.Forms.PictureBox();
            this.norm = new System.Windows.Forms.PictureBox();
            this.fat = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.result_mass = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.none)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.norm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fat)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Индекс массы тела";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 531);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ваш индекс массы тела равен:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш пол: ";
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sex.Location = new System.Drawing.Point(227, 209);
            this.sex.Margin = new System.Windows.Forms.Padding(2);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(238, 37);
            this.sex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(103, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ваш рост (см): ";
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.Location = new System.Drawing.Point(293, 268);
            this.size.Margin = new System.Windows.Forms.Padding(2);
            this.size.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(172, 33);
            this.size.TabIndex = 9;
            // 
            // mass
            // 
            this.mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mass.Location = new System.Drawing.Point(271, 321);
            this.mass.Margin = new System.Windows.Forms.Padding(2);
            this.mass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(194, 33);
            this.mass.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(103, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ваш вес (кг): ";
            // 
            // imt_result
            // 
            this.imt_result.AutoSize = true;
            this.imt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imt_result.Location = new System.Drawing.Point(410, 531);
            this.imt_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imt_result.Name = "imt_result";
            this.imt_result.Size = new System.Drawing.Size(27, 29);
            this.imt_result.TabIndex = 12;
            this.imt_result.Text = "0";
            // 
            // none
            // 
            this.none.Image = global::Курсовая_работа.Properties.Resources.free_icon_question_sign_25333;
            this.none.Location = new System.Drawing.Point(608, 126);
            this.none.Margin = new System.Windows.Forms.Padding(2);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(338, 366);
            this.none.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.none.TabIndex = 13;
            this.none.TabStop = false;
            // 
            // thin
            // 
            this.thin.Image = global::Курсовая_работа.Properties.Resources.orig__1_;
            this.thin.Location = new System.Drawing.Point(607, 124);
            this.thin.Margin = new System.Windows.Forms.Padding(2);
            this.thin.Name = "thin";
            this.thin.Size = new System.Drawing.Size(338, 366);
            this.thin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thin.TabIndex = 2;
            this.thin.TabStop = false;
            this.thin.Visible = false;
            // 
            // norm
            // 
            this.norm.Image = global::Курсовая_работа.Properties.Resources.orig;
            this.norm.Location = new System.Drawing.Point(608, 124);
            this.norm.Margin = new System.Windows.Forms.Padding(2);
            this.norm.Name = "norm";
            this.norm.Size = new System.Drawing.Size(338, 366);
            this.norm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.norm.TabIndex = 1;
            this.norm.TabStop = false;
            this.norm.Visible = false;
            // 
            // fat
            // 
            this.fat.Image = global::Курсовая_работа.Properties.Resources._6c6b5198432b11ee95f66a2aaa288599_upscaled;
            this.fat.Location = new System.Drawing.Point(607, 124);
            this.fat.Margin = new System.Windows.Forms.Padding(2);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(338, 366);
            this.fat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fat.TabIndex = 0;
            this.fat.TabStop = false;
            this.fat.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(526, 531);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ваш вес:";
            // 
            // result_mass
            // 
            this.result_mass.AutoSize = true;
            this.result_mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_mass.Location = new System.Drawing.Point(624, 528);
            this.result_mass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_mass.Name = "result_mass";
            this.result_mass.Size = new System.Drawing.Size(20, 29);
            this.result_mass.TabIndex = 16;
            this.result_mass.Text = " ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 683);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.result_mass);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sex);
            this.tabPage1.Controls.Add(this.imt_result);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.mass);
            this.tabPage1.Controls.Add(this.size);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.none);
            this.tabPage1.Controls.Add(this.fat);
            this.tabPage1.Controls.Add(this.norm);
            this.tabPage1.Controls.Add(this.thin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1066, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Калькулятор индекса массы тела";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(149, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Узнать индекс массы тела";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 644);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Курсовая работа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.none)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.norm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fat)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fat;
        private System.Windows.Forms.PictureBox norm;
        private System.Windows.Forms.PictureBox thin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.NumericUpDown mass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label imt_result;
        private System.Windows.Forms.PictureBox none;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label result_mass;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}

