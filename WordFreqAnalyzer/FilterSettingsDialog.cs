// FilterSettingsDialog.cs
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TextAnalyzer
{
    /// <summary>
    /// Chart display filter settings form
    /// </summary>
    public partial class FilterSettingsDialog : Form
    {
        private FilterSettings settings;

        public FilterSettingsDialog(FilterSettings filterSettings)
        {
            InitializeComponent();
            settings = filterSettings;
            countCombo.SelectedItem = settings.Count.ToString();
            directionBox.SelectedItem = filterSettings.Direction == ListSortDirection.Ascending ? "least" : "most";
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            settings.Count = Convert.ToInt32(countCombo.SelectedItem);
            settings.Direction = directionBox.SelectedText == "least" ? ListSortDirection.Ascending : ListSortDirection.Descending;
        }
    }
}
