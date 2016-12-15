namespace WinFormsBookExpertSystem
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
            this.btnStudyComp = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lbtQuestionText = new System.Windows.Forms.Label();
            this.lblPosValue = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnExplain = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudyComp
            // 
            this.btnStudyComp.Location = new System.Drawing.Point(234, 12);
            this.btnStudyComp.Name = "btnStudyComp";
            this.btnStudyComp.Size = new System.Drawing.Size(173, 29);
            this.btnStudyComp.TabIndex = 0;
            this.btnStudyComp.Text = "Добавить знания";
            this.btnStudyComp.UseVisualStyleBackColor = true;
            this.btnStudyComp.Click += new System.EventHandler(this.btnStudyComp_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(31, 12);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(173, 29);
            this.btnStartTest.TabIndex = 1;
            this.btnStartTest.Text = "Запустить тест";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(300, 177);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(107, 33);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Подтвердить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbtQuestionText
            // 
            this.lbtQuestionText.AutoSize = true;
            this.lbtQuestionText.Location = new System.Drawing.Point(28, 69);
            this.lbtQuestionText.Name = "lbtQuestionText";
            this.lbtQuestionText.Size = new System.Drawing.Size(47, 13);
            this.lbtQuestionText.TabIndex = 3;
            this.lbtQuestionText.Text = "Вопрос:";
            // 
            // lblPosValue
            // 
            this.lblPosValue.AutoSize = true;
            this.lblPosValue.Location = new System.Drawing.Point(28, 130);
            this.lblPosValue.Name = "lblPosValue";
            this.lblPosValue.Size = new System.Drawing.Size(97, 13);
            this.lblPosValue.TabIndex = 4;
            this.lblPosValue.Text = "Варианты ответа:";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(147, 187);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(117, 20);
            this.txtBoxInput.TabIndex = 5;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(28, 187);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(83, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Введите ответ:";
            // 
            // btnExplain
            // 
            this.btnExplain.Location = new System.Drawing.Point(300, 227);
            this.btnExplain.Name = "btnExplain";
            this.btnExplain.Size = new System.Drawing.Size(108, 32);
            this.btnExplain.TabIndex = 7;
            this.btnExplain.Text = "Объяснение ";
            this.btnExplain.UseVisualStyleBackColor = true;
            this.btnExplain.Click += new System.EventHandler(this.btnExplain_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(194, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 32);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 271);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExplain);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblPosValue);
            this.Controls.Add(this.lbtQuestionText);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.btnStudyComp);
            this.Name = "Form1";
            this.Text = "Экспертная система";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudyComp;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lbtQuestionText;
        private System.Windows.Forms.Label lblPosValue;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnExplain;
        private System.Windows.Forms.Button btnBack;
    }
}

