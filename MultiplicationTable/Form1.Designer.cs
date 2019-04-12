namespace MultiplicationTable
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
            this.resultWindow = new System.Windows.Forms.RichTextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.selectNumberRows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullTable = new System.Windows.Forms.RadioButton();
            this.singleTable = new System.Windows.Forms.RadioButton();
            this.selectSpecificNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectCountMultiplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectOptions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultWindow
            // 
            this.resultWindow.Location = new System.Drawing.Point(15, 12);
            this.resultWindow.Name = "resultWindow";
            this.resultWindow.ReadOnly = true;
            this.resultWindow.Size = new System.Drawing.Size(527, 291);
            this.resultWindow.TabIndex = 0;
            this.resultWindow.Text = "";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(429, 394);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(113, 49);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Применить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // selectNumberRows
            // 
            this.selectNumberRows.FormattingEnabled = true;
            this.selectNumberRows.Location = new System.Drawing.Point(12, 378);
            this.selectNumberRows.Name = "selectNumberRows";
            this.selectNumberRows.Size = new System.Drawing.Size(114, 21);
            this.selectNumberRows.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество строк:";
            // 
            // fullTable
            // 
            this.fullTable.AutoSize = true;
            this.fullTable.Checked = true;
            this.fullTable.Location = new System.Drawing.Point(15, 315);
            this.fullTable.Name = "fullTable";
            this.fullTable.Size = new System.Drawing.Size(88, 17);
            this.fullTable.TabIndex = 6;
            this.fullTable.TabStop = true;
            this.fullTable.Text = "Вся таблица";
            this.fullTable.UseVisualStyleBackColor = true;
            this.fullTable.CheckedChanged += new System.EventHandler(this.FullTable_CheckedChanged);
            // 
            // singleTable
            // 
            this.singleTable.AutoSize = true;
            this.singleTable.Location = new System.Drawing.Point(208, 315);
            this.singleTable.Name = "singleTable";
            this.singleTable.Size = new System.Drawing.Size(124, 17);
            this.singleTable.TabIndex = 7;
            this.singleTable.Text = "Одиночная таблица";
            this.singleTable.UseVisualStyleBackColor = true;
            this.singleTable.CheckedChanged += new System.EventHandler(this.SingleTable_CheckedChanged);
            // 
            // selectSpecificNumber
            // 
            this.selectSpecificNumber.Enabled = false;
            this.selectSpecificNumber.FormattingEnabled = true;
            this.selectSpecificNumber.Location = new System.Drawing.Point(208, 378);
            this.selectSpecificNumber.Name = "selectSpecificNumber";
            this.selectSpecificNumber.Size = new System.Drawing.Size(187, 21);
            this.selectSpecificNumber.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Для какого числа вывести таблицу:";
            // 
            // selectCountMultiplier
            // 
            this.selectCountMultiplier.Enabled = false;
            this.selectCountMultiplier.FormattingEnabled = true;
            this.selectCountMultiplier.Location = new System.Drawing.Point(208, 438);
            this.selectCountMultiplier.Name = "selectCountMultiplier";
            this.selectCountMultiplier.Size = new System.Drawing.Size(187, 21);
            this.selectCountMultiplier.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество множителей:";
            // 
            // selectOptions
            // 
            this.selectOptions.FormattingEnabled = true;
            this.selectOptions.Location = new System.Drawing.Point(12, 438);
            this.selectOptions.Name = "selectOptions";
            this.selectOptions.Size = new System.Drawing.Size(120, 43);
            this.selectOptions.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Какие числа выводить в таблице:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectCountMultiplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectSpecificNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.singleTable);
            this.Controls.Add(this.fullTable);
            this.Controls.Add(this.selectNumberRows);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.resultWindow);
            this.Name = "Form1";
            this.Text = "Multiplication table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultWindow;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox selectNumberRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fullTable;
        private System.Windows.Forms.RadioButton singleTable;
        private System.Windows.Forms.ComboBox selectSpecificNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectCountMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox selectOptions;
        private System.Windows.Forms.Label label4;
    }
}

