// SettingsDialog.cs
using System;
using System.Windows.Forms;

namespace TextAnalyzer
{
    /// <summary>
    /// Lets the user change scanning and indexing settings
    /// </summary>
    public partial class SettingsDialog : Form
    {
        private Settings settings;

        public SettingsDialog(Settings mainSettings)
        {
            InitializeComponent();
            settings = mainSettings;
            minLength.SelectedIndex = settings.MinLength;
            numThreads.SelectedIndex = settings.NumThreads - 1;
            maxLinks.Text = settings.MaxLinks.ToString();
            useStopWords.Checked = settings.UseStopWords;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            settings.MinLength = minLength.SelectedIndex;
            settings.NumThreads = numThreads.SelectedIndex + 1;
            settings.MaxLinks = Convert.ToInt32(maxLinks.Text);
            settings.UseStopWords = useStopWords.Checked;
        }
    }
}
