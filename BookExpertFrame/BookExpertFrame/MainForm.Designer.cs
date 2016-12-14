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
            this.chckBoxGenre = new System.Windows.Forms.CheckBox();
            this.chckBoxAuthor = new System.Windows.Forms.CheckBox();
            this.txtBoxCountPage = new System.Windows.Forms.TextBox();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.lblCountPage = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.panelAuthor = new System.Windows.Forms.Panel();
            this.btnAcceptSubframeAuthor = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSubframeNameAuthor = new System.Windows.Forms.Label();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.txtBoxDescribeGenre = new System.Windows.Forms.TextBox();
            this.lblDescribeGenre = new System.Windows.Forms.Label();
            this.txtBoxNameGenre = new System.Windows.Forms.TextBox();
            this.lblNameGenre = new System.Windows.Forms.Label();
            this.lblSubframeNameGenre = new System.Windows.Forms.Label();
            this.btnFindAndFill = new System.Windows.Forms.Button();
            this.btnAcceptSubframeGenre = new System.Windows.Forms.Button();
            this.panelMainFrame.SuspendLayout();
            this.panelAuthor.SuspendLayout();
            this.panelGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainFrame
            // 
            this.panelMainFrame.Controls.Add(this.lblMainFrameName);
            this.panelMainFrame.Controls.Add(this.chckBoxGenre);
            this.panelMainFrame.Controls.Add(this.chckBoxAuthor);
            this.panelMainFrame.Controls.Add(this.txtBoxCountPage);
            this.panelMainFrame.Controls.Add(this.txtBoxGenre);
            this.panelMainFrame.Controls.Add(this.txtBoxAuthor);
            this.panelMainFrame.Controls.Add(this.txtBoxBookName);
            this.panelMainFrame.Controls.Add(this.lblCountPage);
            this.panelMainFrame.Controls.Add(this.lblGenre);
            this.panelMainFrame.Controls.Add(this.lblAuthor);
            this.panelMainFrame.Controls.Add(this.lblBookName);
            this.panelMainFrame.Location = new System.Drawing.Point(12, 12);
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
            // chckBoxGenre
            // 
            this.chckBoxGenre.AutoSize = true;
            this.chckBoxGenre.Location = new System.Drawing.Point(190, 87);
            this.chckBoxGenre.Name = "chckBoxGenre";
            this.chckBoxGenre.Size = new System.Drawing.Size(120, 17);
            this.chckBoxGenre.TabIndex = 19;
            this.chckBoxGenre.Text = "Субфрейм \"Жанр\"";
            this.chckBoxGenre.UseVisualStyleBackColor = true;
            this.chckBoxGenre.CheckedChanged += new System.EventHandler(this.chckBoxGenre_CheckedChanged);
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
            this.txtBoxCountPage.Location = new System.Drawing.Point(97, 116);
            this.txtBoxCountPage.Name = "txtBoxCountPage";
            this.txtBoxCountPage.Size = new System.Drawing.Size(87, 20);
            this.txtBoxCountPage.TabIndex = 17;
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(74, 88);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(110, 20);
            this.txtBoxGenre.TabIndex = 16;
            // 
            // txtBoxAuthor
            // 
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
            this.lblCountPage.Location = new System.Drawing.Point(8, 119);
            this.lblCountPage.Name = "lblCountPage";
            this.lblCountPage.Size = new System.Drawing.Size(83, 13);
            this.lblCountPage.TabIndex = 13;
            this.lblCountPage.Text = "Число страниц";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(8, 88);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Жанр";
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
            this.panelAuthor.Controls.Add(this.lblCountry);
            this.panelAuthor.Controls.Add(this.txtBoxCountry);
            this.panelAuthor.Controls.Add(this.txtBoxLastName);
            this.panelAuthor.Controls.Add(this.lblLastName);
            this.panelAuthor.Controls.Add(this.lblSubframeNameAuthor);
            this.panelAuthor.Location = new System.Drawing.Point(337, 11);
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
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(26, 92);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Страна";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.Location = new System.Drawing.Point(75, 89);
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(101, 20);
            this.txtBoxCountry.TabIndex = 3;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(75, 61);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(101, 20);
            this.txtBoxLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 64);
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
            // panelGenre
            // 
            this.panelGenre.Controls.Add(this.btnAcceptSubframeGenre);
            this.panelGenre.Controls.Add(this.txtBoxDescribeGenre);
            this.panelGenre.Controls.Add(this.lblDescribeGenre);
            this.panelGenre.Controls.Add(this.txtBoxNameGenre);
            this.panelGenre.Controls.Add(this.lblNameGenre);
            this.panelGenre.Controls.Add(this.lblSubframeNameGenre);
            this.panelGenre.Location = new System.Drawing.Point(533, 12);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(227, 185);
            this.panelGenre.TabIndex = 12;
            // 
            // txtBoxDescribeGenre
            // 
            this.txtBoxDescribeGenre.Location = new System.Drawing.Point(80, 94);
            this.txtBoxDescribeGenre.Multiline = true;
            this.txtBoxDescribeGenre.Name = "txtBoxDescribeGenre";
            this.txtBoxDescribeGenre.Size = new System.Drawing.Size(128, 52);
            this.txtBoxDescribeGenre.TabIndex = 4;
            // 
            // lblDescribeGenre
            // 
            this.lblDescribeGenre.AutoSize = true;
            this.lblDescribeGenre.Location = new System.Drawing.Point(12, 95);
            this.lblDescribeGenre.Name = "lblDescribeGenre";
            this.lblDescribeGenre.Size = new System.Drawing.Size(57, 13);
            this.lblDescribeGenre.TabIndex = 3;
            this.lblDescribeGenre.Text = "Описание";
            // 
            // txtBoxNameGenre
            // 
            this.txtBoxNameGenre.Location = new System.Drawing.Point(75, 59);
            this.txtBoxNameGenre.Name = "txtBoxNameGenre";
            this.txtBoxNameGenre.Size = new System.Drawing.Size(133, 20);
            this.txtBoxNameGenre.TabIndex = 2;
            // 
            // lblNameGenre
            // 
            this.lblNameGenre.AutoSize = true;
            this.lblNameGenre.Location = new System.Drawing.Point(12, 62);
            this.lblNameGenre.Name = "lblNameGenre";
            this.lblNameGenre.Size = new System.Drawing.Size(57, 13);
            this.lblNameGenre.TabIndex = 1;
            this.lblNameGenre.Text = "Название";
            // 
            // lblSubframeNameGenre
            // 
            this.lblSubframeNameGenre.AutoSize = true;
            this.lblSubframeNameGenre.Location = new System.Drawing.Point(45, 11);
            this.lblSubframeNameGenre.Name = "lblSubframeNameGenre";
            this.lblSubframeNameGenre.Size = new System.Drawing.Size(101, 13);
            this.lblSubframeNameGenre.TabIndex = 0;
            this.lblSubframeNameGenre.Text = "Субфрейм \"Жанр\"";
            // 
            // btnFindAndFill
            // 
            this.btnFindAndFill.Location = new System.Drawing.Point(653, 209);
            this.btnFindAndFill.Name = "btnFindAndFill";
            this.btnFindAndFill.Size = new System.Drawing.Size(108, 26);
            this.btnFindAndFill.TabIndex = 13;
            this.btnFindAndFill.Text = "Найти";
            this.btnFindAndFill.UseVisualStyleBackColor = true;
            // 
            // btnAcceptSubframeGenre
            // 
            this.btnAcceptSubframeGenre.Location = new System.Drawing.Point(133, 152);
            this.btnAcceptSubframeGenre.Name = "btnAcceptSubframeGenre";
            this.btnAcceptSubframeGenre.Size = new System.Drawing.Size(75, 21);
            this.btnAcceptSubframeGenre.TabIndex = 5;
            this.btnAcceptSubframeGenre.Text = "ОК";
            this.btnAcceptSubframeGenre.UseVisualStyleBackColor = true;
            // 
            // frmFrameExpertSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 247);
            this.Controls.Add(this.btnFindAndFill);
            this.Controls.Add(this.panelGenre);
            this.Controls.Add(this.panelAuthor);
            this.Controls.Add(this.panelMainFrame);
            this.Name = "frmFrameExpertSystem";
            this.Text = "Экспертная система на фреймах";
            this.Load += new System.EventHandler(this.frmFrameExpertSystem_Load);
            this.panelMainFrame.ResumeLayout(false);
            this.panelMainFrame.PerformLayout();
            this.panelAuthor.ResumeLayout(false);
            this.panelAuthor.PerformLayout();
            this.panelGenre.ResumeLayout(false);
            this.panelGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainFrame;
        private System.Windows.Forms.Label lblMainFrameName;
        private System.Windows.Forms.CheckBox chckBoxGenre;
        private System.Windows.Forms.CheckBox chckBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxCountPage;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.Label lblCountPage;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Panel panelAuthor;
        private System.Windows.Forms.Button btnAcceptSubframeAuthor;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSubframeNameAuthor;
        private System.Windows.Forms.Panel panelGenre;
        private System.Windows.Forms.TextBox txtBoxDescribeGenre;
        private System.Windows.Forms.Label lblDescribeGenre;
        private System.Windows.Forms.TextBox txtBoxNameGenre;
        private System.Windows.Forms.Label lblNameGenre;
        private System.Windows.Forms.Label lblSubframeNameGenre;
        private System.Windows.Forms.Button btnFindAndFill;
        private System.Windows.Forms.Button btnAcceptSubframeGenre;
    }
}

