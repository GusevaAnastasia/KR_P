
namespace KR
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.secondInput = new System.Windows.Forms.TextBox();
            this.AccMultiply = new System.Windows.Forms.Button();
            this.Equivalence = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultOutput = new System.Windows.Forms.Label();
            this.flagsOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstOutput = new System.Windows.Forms.Label();
            this.secondOutput = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(14, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Первое число в 2СС";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(14, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Второе число в 2СС";
            // 
            // firstInput
            // 
            this.firstInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firstInput.Location = new System.Drawing.Point(341, 39);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(100, 39);
            this.firstInput.TabIndex = 4;
            this.firstInput.TextChanged += new System.EventHandler(this.firstInput_TextChanged);
            // 
            // secondInput
            // 
            this.secondInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.secondInput.Location = new System.Drawing.Point(341, 152);
            this.secondInput.Name = "secondInput";
            this.secondInput.Size = new System.Drawing.Size(100, 39);
            this.secondInput.TabIndex = 5;
            this.secondInput.TextChanged += new System.EventHandler(this.secondInput_TextChanged);
            // 
            // AccMultiply
            // 
            this.AccMultiply.Location = new System.Drawing.Point(12, 435);
            this.AccMultiply.Name = "AccMultiply";
            this.AccMultiply.Size = new System.Drawing.Size(244, 50);
            this.AccMultiply.TabIndex = 6;
            this.AccMultiply.Text = "Ускоренное умножение";
            this.AccMultiply.UseVisualStyleBackColor = true;
            this.AccMultiply.Click += new System.EventHandler(this.AccMultiply_Click);
            // 
            // Equivalence
            // 
            this.Equivalence.Location = new System.Drawing.Point(262, 435);
            this.Equivalence.Name = "Equivalence";
            this.Equivalence.Size = new System.Drawing.Size(241, 50);
            this.Equivalence.TabIndex = 7;
            this.Equivalence.Text = "Эквивалентность";
            this.Equivalence.UseVisualStyleBackColor = true;
            this.Equivalence.Click += new System.EventHandler(this.Equivalence_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(18, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Результат: ";
            // 
            // resultOutput
            // 
            this.resultOutput.AutoSize = true;
            this.resultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.resultOutput.Location = new System.Drawing.Point(190, 286);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(0, 32);
            this.resultOutput.TabIndex = 9;
            // 
            // flagsOutput
            // 
            this.flagsOutput.AutoSize = true;
            this.flagsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.flagsOutput.Location = new System.Drawing.Point(190, 354);
            this.flagsOutput.Name = "flagsOutput";
            this.flagsOutput.Size = new System.Drawing.Size(0, 32);
            this.flagsOutput.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(18, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Флаги: ";
            // 
            // firstOutput
            // 
            this.firstOutput.AutoSize = true;
            this.firstOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firstOutput.Location = new System.Drawing.Point(335, 101);
            this.firstOutput.Name = "firstOutput";
            this.firstOutput.Size = new System.Drawing.Size(0, 32);
            this.firstOutput.TabIndex = 12;
            // 
            // secondOutput
            // 
            this.secondOutput.AutoSize = true;
            this.secondOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.secondOutput.Location = new System.Drawing.Point(335, 207);
            this.secondOutput.Name = "secondOutput";
            this.secondOutput.Size = new System.Drawing.Size(0, 32);
            this.secondOutput.TabIndex = 13;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(509, 435);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(149, 50);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(664, 435);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 50);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.secondOutput);
            this.Controls.Add(this.firstOutput);
            this.Controls.Add(this.flagsOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Equivalence);
            this.Controls.Add(this.AccMultiply);
            this.Controls.Add(this.secondInput);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Арифметико-логическое устройство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox secondInput;
        private System.Windows.Forms.Button AccMultiply;
        private System.Windows.Forms.Button Equivalence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultOutput;
        private System.Windows.Forms.Label flagsOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label firstOutput;
        private System.Windows.Forms.Label secondOutput;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

