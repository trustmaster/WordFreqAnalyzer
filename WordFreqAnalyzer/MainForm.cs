// MainForm.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace TextAnalyzer
{
    /// <summary>
    /// Main application form
    /// </summary>
    public partial class MainForm : Form
    {
        private MainController controller;

        public MainForm(MainController mc)
        {
            controller = mc;
            InitializeComponent();
            zgraph.GraphPane.Title.Text = "Word frequency chart";
            zgraph.GraphPane.XAxis.Title.Text = "Word";
            zgraph.GraphPane.XAxis.Type = AxisType.Text;
            zgraph.GraphPane.YAxis.Title.Text = "Entries";
            zgraph.IsShowPointValues = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = controller.GetSettings();
            if (res == DialogResult.OK)
                UpdateStatus("Settings are accepted and will be applied on the next Analyze call");
        }

        private void graphFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = controller.GetFilterSettings();
            if (res == DialogResult.OK)
            {
                UpdateGraph();
                UpdateStatus("New filter settings are applied on chart");
            }
        }

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog flg = new OpenFileDialog();
            flg.CheckFileExists = true;
            //flg.Filter = "Документы HTML (*.html, *.htm)|*.html;*.htm|Документы Word (*.doc, *.docx)|*.doc;*.docx|Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            flg.Filter = "HTML documents (*.html, *.htm)|*.html;*.htm|Text files (*.txt, *.*)|*.txt;*.*";
            DialogResult res = flg.ShowDialog();
            if (res == DialogResult.OK)
            {
                UpdateStatus("Analyzing. Please wait...");
                controller.AnalyzeDocument(flg.FileName);
                UpdateStatus("Analysis complete.");
                UpdateReport();
                UpdateGraph();
            }
        }

        private void analyzeURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrlDialog ulg = new UrlDialog();
            DialogResult res = ulg.ShowDialog();
            if (res == DialogResult.OK)
            {
                UpdateStatus("Analyzing. Please wait...");
                controller.AnalyzeUrl(ulg.Url);
                UpdateStatus("Analysis complete.");
                UpdateReport();
                UpdateGraph();
            }
        }

        private void UpdateStatus(string text)
        {
            statusLabel.Text = text;
            statusLabel.Invalidate();
            statusBar.Invalidate();
            statusBar.Update();
        }

        private void UpdateReport()
        {
            UpdateStatus("Готово");
            KeyValuePair<string, int> maxFreq = controller.GetMaxFreqPair();
            KeyValuePair<string, int> minFreq = controller.GetMinFreqPair();
            maxFreqWord.Text = string.Format("{0} ({1})", maxFreq.Key, maxFreq.Value);
            minFreqWord.Text = string.Format("{0} ({1})", minFreq.Key, minFreq.Value);
            wordGrid.DataSource = controller.GetBinding();
            wordGrid.Columns[0].HeaderText = "Word";
            wordGrid.Columns[1].HeaderText = "Entries";
        }

        private void UpdateGraph()
        {
            Index displayedIndex = controller.GetDisplayedIndex();
            GraphPane pane = zgraph.GraphPane;
            PointPairList ppl = new PointPairList();
            int i = 0;
            string[] labels = new string[displayedIndex.Count];
            foreach (KeyValuePair<string, int> pair in displayedIndex)
            {
                PointPair pp = new PointPair((double)i, (double)pair.Value, pair.Key);
                labels[i] = pair.Key;
                ppl.Add(pp);
                i++;
            }
            pane.CurveList.Clear();
            pane.GraphObjList.Clear();
            BarItem curve = pane.AddBar("number of entries", ppl, Color.Red);
            pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
            zgraph.AxisChange();
            pane.XAxis.Scale.TextLabels = labels;
            BarItem.CreateBarLabels(pane, true, "f0");
            zgraph.AxisChange();
            zgraph.Invalidate();
            zgraph.Update();
        }
    }
}
