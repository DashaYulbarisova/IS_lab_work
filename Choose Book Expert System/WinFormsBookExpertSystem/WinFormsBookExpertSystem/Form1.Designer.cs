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
            this.SuspendLayout();
            // 
            // btnStudyComp
            // 
            this.btnStudyComp.Location = new System.Drawing.Point(12, 21);
            this.btnStudyComp.Name = "btnStudyComp";
            this.btnStudyComp.Size = new System.Drawing.Size(163, 68);
            this.btnStudyComp.TabIndex = 0;
            this.btnStudyComp.Text = "Компонент приобретения знаний";
            this.btnStudyComp.UseVisualStyleBackColor = true;
            this.btnStudyComp.Click += new System.EventHandler(this.btnStudyComp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 276);
            this.Controls.Add(this.btnStudyComp);
            this.Name = "Form1";
            this.Text = "Экспертная система";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudyComp;
    }
}

