// MainController.cs
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace TextAnalyzer
{
    /// <summary>
    /// Top level controller implementing application logics
    /// </summary>
    public class MainController
    {
        private Settings settings;
        private FilterSettings filterSettings;
        private Index index;
        private IndexBinding binding;

        public MainController()
        {
            settings = new Settings(3, 4, 1000, true);
            filterSettings = new FilterSettings(ListSortDirection.Descending, 5);
            index = null;
        }

        public IndexBinding GetBinding()
        {
            return binding;
        }

        public Index GetDisplayedIndex()
        {
            IndexFilter filter = new IndexFilter(filterSettings);
            return filter.Filter(binding);
        }

        public KeyValuePair<string, int> GetMaxFreqPair()
        {
            return index.GetMaxFreqPair();
        }

        public KeyValuePair<string, int> GetMinFreqPair()
        {
            return index.GetMinFreqPair();
        }

        public DialogResult GetFilterSettings()
        {
            FilterSettingsDialog sd = new FilterSettingsDialog(filterSettings);
            return sd.ShowDialog();
        }

        public DialogResult GetSettings()
        {
            SettingsDialog sd = new SettingsDialog(settings);
            return sd.ShowDialog();
        }

        public void AnalyzeDocument(string path)
        {
            Scanner sr = new DocumentScanner(settings);
            RunScanner(sr, path);
        }

        public void AnalyzeUrl(string url)
        {
            Scanner sr = new SiteScanner(settings);
            RunScanner(sr, url);
        }

        private void RunScanner(Scanner sr, string path)
        {
            sr.Scan(path);
            index = sr.GetIndex();
            binding = new IndexBinding(index);
        }
    }
}
