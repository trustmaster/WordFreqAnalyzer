// SettingsDialog.Designer.cs
namespace TextAnalyzer
{
    partial class SettingsDialog
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
            this.useStopWords = new System.Windows.Forms.CheckBox();
            this.minLength = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxLinks = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min word length:";
            // 
            // useStopWords
            // 
            this.useStopWords.AutoSize = true;
            this.useStopWords.Location = new System.Drawing.Point(12, 86);
            this.useStopWords.Name = "useStopWords";
            this.useStopWords.Size = new System.Drawing.Size(234, 17);
            this.useStopWords.TabIndex = 3;
            this.useStopWords.Text = "Exclude common stop words";
            this.useStopWords.UseVisualStyleBackColor = true;
            // 
            // minLength
            // 
            this.minLength.FormattingEnabled = true;
            this.minLength.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.minLength.Location = new System.Drawing.Point(159, 6);
            this.minLength.Name = "minLength";
            this.minLength.Size = new System.Drawing.Size(121, 21);
            this.minLength.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Concurrent threads:";
            // 
            // numThreads
            // 
            this.numThreads.FormattingEnabled = true;
            this.numThreads.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.numThreads.Location = new System.Drawing.Point(159, 33);
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(121, 21);
            this.numThreads.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max links per site:";
            // 
            // maxLinks
            // 
            this.maxLinks.Location = new System.Drawing.Point(159, 60);
            this.maxLinks.MaxLength = 16;
            this.maxLinks.Name = "maxLinks";
            this.maxLinks.Size = new System.Drawing.Size(100, 20);
            this.maxLinks.TabIndex = 8;
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyButton.Location = new System.Drawing.Point(63, 109);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(159, 109);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 142);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.maxLinks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minLength);
            this.Controls.Add(this.useStopWords);
            this.Controls.Add(this.label1);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox useStopWords;
        private System.Windows.Forms.ComboBox minLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numThreads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxLinks;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelBtn;
    }
}