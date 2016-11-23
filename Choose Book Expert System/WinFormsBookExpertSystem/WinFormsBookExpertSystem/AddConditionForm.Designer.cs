namespace WinFormsBookExpertSystem
{
    partial class AddConditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNameFact = new System.Windows.Forms.TextBox();
            this.txtBoxValueFact = new System.Windows.Forms.TextBox();
            this.txtBoxSign = new System.Windows.Forms.TextBox();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название факта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значение факта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логический знак";
            // 
            // txtBoxNameFact
            // 
            this.txtBoxNameFact.Location = new System.Drawing.Point(160, 21);
            this.txtBoxNameFact.Name = "txtBoxNameFact";
            this.txtBoxNameFact.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNameFact.TabIndex = 3;
            this.txtBoxNameFact.Text = "start";
            // 
            // txtBoxValueFact
            // 
            this.txtBoxValueFact.Location = new System.Drawing.Point(160, 60);
            this.txtBoxValueFact.Name = "txtBoxValueFact";
            this.txtBoxValueFact.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValueFact.TabIndex = 4;
            this.txtBoxValueFact.Text = "yes";
            // 
            // txtBoxSign
            // 
            this.txtBoxSign.Location = new System.Drawing.Point(159, 104);
            this.txtBoxSign.Name = "txtBoxSign";
            this.txtBoxSign.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSign.TabIndex = 5;
            this.txtBoxSign.Text = "null";
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(45, 154);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(215, 44);
            this.btnAddCondition.TabIndex = 6;
            this.btnAddCondition.Text = "Добавить";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            // 
            // AddConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 221);
            this.Controls.Add(this.btnAddCondition);
            this.Controls.Add(this.txtBoxSign);
            this.Controls.Add(this.txtBoxValueFact);
            this.Controls.Add(this.txtBoxNameFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddConditionForm";
            this.Text = "Добавление условия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNameFact;
        private System.Windows.Forms.TextBox txtBoxValueFact;
        private System.Windows.Forms.TextBox txtBoxSign;
        private System.Windows.Forms.Button btnAddCondition;
    }
}