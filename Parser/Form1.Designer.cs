namespace Parser
{
    partial class ParserForm
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
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonHabr = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(630, 537);
            this.ListTitles.TabIndex = 0;
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(723, 31);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownStart.TabIndex = 1;
            this.numericUpDownStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(723, 76);
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownEnd.TabIndex = 2;
            this.numericUpDownEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonHabr
            // 
            this.buttonHabr.Location = new System.Drawing.Point(660, 132);
            this.buttonHabr.Name = "buttonHabr";
            this.buttonHabr.Size = new System.Drawing.Size(112, 23);
            this.buttonHabr.TabIndex = 3;
            this.buttonHabr.Text = "GO";
            this.buttonHabr.UseVisualStyleBackColor = true;
            this.buttonHabr.Click += new System.EventHandler(this.buttonHabr_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(697, 526);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(663, 161);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(109, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "StopParsing";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "End page";
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHabr);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.ListTitles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ParserForm";
            this.Text = "Parser";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.Load += new System.EventHandler(this.ParserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.Button buttonHabr;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

