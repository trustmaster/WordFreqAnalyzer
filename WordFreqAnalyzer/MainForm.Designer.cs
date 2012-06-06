// MainForm.Designer.cs
namespace TextAnalyzer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.reportPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minFreqWord = new System.Windows.Forms.Label();
            this.maxFreqWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wordGrid = new System.Windows.Forms.DataGridView();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.plotPage = new System.Windows.Forms.TabPage();
            this.zgraph = new ZedGraph.ZedGraphControl();
            this.graphFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.tabs.SuspendLayout();
            this.reportPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordGrid)).BeginInit();
            this.statusBar.SuspendLayout();
            this.plotPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(699, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyzeToolStripMenuItem,
            this.analyzeURLToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            this.analyzeToolStripMenuItem.Click += new System.EventHandler(this.analyzeToolStripMenuItem_Click);
            // 
            // analyzeURLToolStripMenuItem
            // 
            this.analyzeURLToolStripMenuItem.Name = "analyzeURLToolStripMenuItem";
            this.analyzeURLToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.analyzeURLToolStripMenuItem.Text = "Analyze URL";
            this.analyzeURLToolStripMenuItem.Click += new System.EventHandler(this.analyzeURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersToolStripMenuItem,
            this.graphFilterToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.reportPage);
            this.tabs.Controls.Add(this.plotPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 24);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(699, 612);
            this.tabs.TabIndex = 1;
            // 
            // reportPage
            // 
            this.reportPage.Controls.Add(this.groupBox1);
            this.reportPage.Controls.Add(this.wordGrid);
            this.reportPage.Controls.Add(this.statusBar);
            this.reportPage.Location = new System.Drawing.Point(4, 22);
            this.reportPage.Name = "reportPage";
            this.reportPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportPage.Size = new System.Drawing.Size(691, 586);
            this.reportPage.TabIndex = 0;
            this.reportPage.Text = "Report";
            this.reportPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minFreqWord);
            this.groupBox1.Controls.Add(this.maxFreqWord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extremal values";
            // 
            // minFreqWord
            // 
            this.minFreqWord.AutoSize = true;
            this.minFreqWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minFreqWord.Location = new System.Drawing.Point(189, 47);
            this.minFreqWord.Name = "minFreqWord";
            this.minFreqWord.Size = new System.Drawing.Size(118, 13);
            this.minFreqWord.TabIndex = 3;
            this.minFreqWord.Text = "word (entries)";
            // 
            // maxFreqWord
            // 
            this.maxFreqWord.AutoSize = true;
            this.maxFreqWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxFreqWord.Location = new System.Drawing.Point(189, 25);
            this.maxFreqWord.Name = "maxFreqWord";
            this.maxFreqWord.Size = new System.Drawing.Size(118, 13);
            this.maxFreqWord.TabIndex = 2;
            this.maxFreqWord.Text = "word (entries)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min frequency word:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max frequency word:";
            // 
            // wordGrid
            // 
            this.wordGrid.AllowUserToAddRows = false;
            this.wordGrid.AllowUserToDeleteRows = false;
            this.wordGrid.AllowUserToOrderColumns = true;
            this.wordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wordGrid.Location = new System.Drawing.Point(3, 79);
            this.wordGrid.Name = "wordGrid";
            this.wordGrid.ReadOnly = true;
            this.wordGrid.Size = new System.Drawing.Size(685, 482);
            this.wordGrid.TabIndex = 1;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(3, 561);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(685, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(107, 17);
            this.statusLabel.Text = "Waiting for a command";
            // 
            // plotPage
            // 
            this.plotPage.Controls.Add(this.zgraph);
            this.plotPage.Location = new System.Drawing.Point(4, 22);
            this.plotPage.Name = "plotPage";
            this.plotPage.Padding = new System.Windows.Forms.Padding(3);
            this.plotPage.Size = new System.Drawing.Size(691, 586);
            this.plotPage.TabIndex = 1;
            this.plotPage.Text = "Chart";
            this.plotPage.UseVisualStyleBackColor = true;
            // 
            // zgraph
            // 
            this.zgraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgraph.Location = new System.Drawing.Point(3, 3);
            this.zgraph.Name = "zgraph";
            this.zgraph.ScrollGrace = 0;
            this.zgraph.ScrollMaxX = 0;
            this.zgraph.ScrollMaxY = 0;
            this.zgraph.ScrollMaxY2 = 0;
            this.zgraph.ScrollMinX = 0;
            this.zgraph.ScrollMinY = 0;
            this.zgraph.ScrollMinY2 = 0;
            this.zgraph.Size = new System.Drawing.Size(685, 580);
            this.zgraph.TabIndex = 0;
            // 
            // graphFilterToolStripMenuItem
            // 
            this.graphFilterToolStripMenuItem.Name = "graphFilterToolStripMenuItem";
            this.graphFilterToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.graphFilterToolStripMenuItem.Text = "Chart filter";
            this.graphFilterToolStripMenuItem.Click += new System.EventHandler(this.graphFilterToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 636);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Word Fequency Analysis";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.reportPage.ResumeLayout(false);
            this.reportPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordGrid)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.plotPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage reportPage;
        private System.Windows.Forms.TabPage plotPage;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView wordGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minFreqWord;
        private System.Windows.Forms.Label maxFreqWord;
        private ZedGraph.ZedGraphControl zgraph;
        private System.Windows.Forms.ToolStripMenuItem graphFilterToolStripMenuItem;
    }
}

