namespace BookExpertFrame
{
    partial class frmFrameExpertSystem
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
            this.panelMainFrame = new System.Windows.Forms.Panel();
            this.lblMainFrameName = new System.Windows.Forms.Label();
            this.chckBoxAuthor = new System.Windows.Forms.CheckBox();
            this.txtBoxCountPage = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.lblCountPage = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.panelAuthor = new System.Windows.Forms.Panel();
            this.btnAcceptSubframeAuthor = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSubframeNameAuthor = new System.Windows.Forms.Label();
            this.btnFindAndFill = new System.Windows.Forms.Button();
            this.panelChooseFrame = new System.Windows.Forms.Panel();
            this.radioBtnRoadBook = new System.Windows.Forms.RadioButton();
            this.radioBtnHomeBook = new System.Windows.Forms.RadioButton();
            this.panelMainFrame.SuspendLayout();
            this.panelAuthor.SuspendLayout();
            this.panelChooseFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainFrame
            // 
            this.panelMainFrame.Controls.Add(this.lblMainFrameName);
            this.panelMainFrame.Controls.Add(this.chckBoxAuthor);
            this.panelMainFrame.Controls.Add(this.txtBoxCountPage);
            this.panelMainFrame.Controls.Add(this.txtBoxAuthor);
            this.panelMainFrame.Controls.Add(this.txtBoxBookName);
            this.panelMainFrame.Controls.Add(this.lblCountPage);
            this.panelMainFrame.Controls.Add(this.lblAuthor);
            this.panelMainFrame.Controls.Add(this.lblBookName);
            this.panelMainFrame.Location = new System.Drawing.Point(12, 66);
            this.panelMainFrame.Name = "panelMainFrame";
            this.panelMainFrame.Size = new System.Drawing.Size(319, 185);
            this.panelMainFrame.TabIndex = 10;
            // 
            // lblMainFrameName
            // 
            this.lblMainFrameName.AutoSize = true;
            this.lblMainFrameName.Location = new System.Drawing.Point(107, 11);
            this.lblMainFrameName.Name = "lblMainFrameName";
            this.lblMainFrameName.Size = new System.Drawing.Size(87, 13);
            this.lblMainFrameName.TabIndex = 20;
            this.lblMainFrameName.Text = "Фрейм \"Книга\"";
            // 
            // chckBoxAuthor
            // 
            this.chckBoxAuthor.AutoSize = true;
            this.chckBoxAuthor.Location = new System.Drawing.Point(190, 62);
            this.chckBoxAuthor.Name = "chckBoxAuthor";
            this.chckBoxAuthor.Size = new System.Drawing.Size(121, 17);
            this.chckBoxAuthor.TabIndex = 18;
            this.chckBoxAuthor.Text = "Субфрейм \"Автор\"";
            this.chckBoxAuthor.UseVisualStyleBackColor = true;
            this.chckBoxAuthor.CheckedChanged += new System.EventHandler(this.chckBoxAuthor_CheckedChanged);
            // 
            // txtBoxCountPage
            // 
            this.txtBoxCountPage.Enabled = false;
            this.txtBoxCountPage.Location = new System.Drawing.Point(97, 91);
            this.txtBoxCountPage.Name = "txtBoxCountPage";
            this.txtBoxCountPage.Size = new System.Drawing.Size(87, 20);
            this.txtBoxCountPage.TabIndex = 17;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Enabled = false;
            this.txtBoxAuthor.Location = new System.Drawing.Point(74, 60);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(110, 20);
            this.txtBoxAuthor.TabIndex = 15;
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Location = new System.Drawing.Point(74, 32);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(113, 20);
            this.txtBoxBookName.TabIndex = 14;
            // 
            // lblCountPage
            // 
            this.lblCountPage.AutoSize = true;
            this.lblCountPage.Location = new System.Drawing.Point(8, 94);
            this.lblCountPage.Name = "lblCountPage";
            this.lblCountPage.Size = new System.Drawing.Size(83, 13);
            this.lblCountPage.TabIndex = 13;
            this.lblCountPage.Text = "Число страниц";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(8, 60);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(37, 13);
            this.lblAuthor.TabIndex = 11;
            this.lblAuthor.Text = "Автор";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(8, 32);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(57, 13);
            this.lblBookName.TabIndex = 10;
            this.lblBookName.Text = "Название";
            // 
            // panelAuthor
            // 
            this.panelAuthor.Controls.Add(this.btnAcceptSubframeAuthor);
            this.panelAuthor.Controls.Add(this.lblGenre);
            this.panelAuthor.Controls.Add(this.txtBoxGenre);
            this.panelAuthor.Controls.Add(this.txtBoxLastName);
            this.panelAuthor.Controls.Add(this.lblLastName);
            this.panelAuthor.Controls.Add(this.lblSubframeNameAuthor);
            this.panelAuthor.Location = new System.Drawing.Point(337, 65);
            this.panelAuthor.Name = "panelAuthor";
            this.panelAuthor.Size = new System.Drawing.Size(190, 186);
            this.panelAuthor.TabIndex = 11;
            // 
            // btnAcceptSubframeAuthor
            // 
            this.btnAcceptSubframeAuthor.Location = new System.Drawing.Point(102, 153);
            this.btnAcceptSubframeAuthor.Name = "btnAcceptSubframeAuthor";
            this.btnAcceptSubframeAuthor.Size = new System.Drawing.Size(74, 21);
            this.btnAcceptSubframeAuthor.TabIndex = 5;
            this.btnAcceptSubframeAuthor.Text = "ОК";
            this.btnAcceptSubframeAuthor.UseVisualStyleBackColor = true;
            this.btnAcceptSubframeAuthor.Click += new System.EventHandler(this.btnAcceptSubframeAuthor_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(26, 92);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Жанр";
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(75, 89);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(101, 20);
            this.txtBoxGenre.TabIndex = 3;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(75, 51);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(101, 20);
            this.txtBoxLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 51);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblSubframeNameAuthor
            // 
            this.lblSubframeNameAuthor.AutoSize = true;
            this.lblSubframeNameAuthor.Location = new System.Drawing.Point(42, 12);
            this.lblSubframeNameAuthor.Name = "lblSubframeNameAuthor";
            this.lblSubframeNameAuthor.Size = new System.Drawing.Size(102, 13);
            this.lblSubframeNameAuthor.TabIndex = 0;
            this.lblSubframeNameAuthor.Text = "Субфрейм \"Автор\"";
            // 
            // btnFindAndFill
            // 
            this.btnFindAndFill.Location = new System.Drawing.Point(419, 263);
            this.btnFindAndFill.Name = "btnFindAndFill";
            this.btnFindAndFill.Size = new System.Drawing.Size(108, 26);
            this.btnFindAndFill.TabIndex = 13;
            this.btnFindAndFill.Text = "Найти";
            this.btnFindAndFill.UseVisualStyleBackColor = true;
            // 
            // panelChooseFrame
            // 
            this.panelChooseFrame.Controls.Add(this.radioBtnHomeBook);
            this.panelChooseFrame.Controls.Add(this.radioBtnRoadBook);
            this.panelChooseFrame.Location = new System.Drawing.Point(11, 11);
            this.panelChooseFrame.Name = "panelChooseFrame";
            this.panelChooseFrame.Size = new System.Drawing.Size(515, 40);
            this.panelChooseFrame.TabIndex = 14;
            // 
            // radioBtnRoadBook
            // 
            this.radioBtnRoadBook.AutoSize = true;
            this.radioBtnRoadBook.Location = new System.Drawing.Point(24, 9);
            this.radioBtnRoadBook.Name = "radioBtnRoadBook";
            this.radioBtnRoadBook.Size = new System.Drawing.Size(101, 17);
            this.radioBtnRoadBook.TabIndex = 0;
            this.radioBtnRoadBook.TabStop = true;
            this.radioBtnRoadBook.Text = "Книга в дорогу";
            this.radioBtnRoadBook.UseVisualStyleBackColor = true;
            this.radioBtnRoadBook.CheckedChanged += new System.EventHandler(this.radioBtnRoadBook_CheckedChanged);
            // 
            // radioBtnHomeBook
            // 
            this.radioBtnHomeBook.AutoSize = true;
            this.radioBtnHomeBook.Location = new System.Drawing.Point(355, 9);
            this.radioBtnHomeBook.Name = "radioBtnHomeBook";
            this.radioBtnHomeBook.Size = new System.Drawing.Size(142, 17);
            this.radioBtnHomeBook.TabIndex = 1;
            this.radioBtnHomeBook.TabStop = true;
            this.radioBtnHomeBook.Text = "Книга для чтения дома";
            this.radioBtnHomeBook.UseVisualStyleBackColor = true;
            this.radioBtnHomeBook.CheckedChanged += new System.EventHandler(this.radioBtnHomeBook_CheckedChanged);
            // 
            // frmFrameExpertSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 301);
            this.Controls.Add(this.panelChooseFrame);
            this.Controls.Add(this.btnFindAndFill);
            this.Controls.Add(this.panelAuthor);
            this.Controls.Add(this.panelMainFrame);
            this.Name = "frmFrameExpertSystem";
            this.Text = "Экспертная система на фреймах";
            this.Load += new System.EventHandler(this.frmFrameExpertSystem_Load);
            this.panelMainFrame.ResumeLayout(false);
            this.panelMainFrame.PerformLayout();
            this.panelAuthor.ResumeLayout(false);
            this.panelAuthor.PerformLayout();
            this.panelChooseFrame.ResumeLayout(false);
            this.panelChooseFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainFrame;
        private System.Windows.Forms.Label lblMainFrameName;
        private System.Windows.Forms.CheckBox chckBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxCountPage;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.Label lblCountPage;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Panel panelAuthor;
        private System.Windows.Forms.Button btnAcceptSubframeAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSubframeNameAuthor;
        private System.Windows.Forms.Button btnFindAndFill;
        private System.Windows.Forms.Panel panelChooseFrame;
        private System.Windows.Forms.RadioButton radioBtnHomeBook;
        private System.Windows.Forms.RadioButton radioBtnRoadBook;
    }
}

