// UrlDialog.cs
using System;
using System.Windows.Forms;

namespace TextAnalyzer
{
    /// <summary>
    /// Web URL input form
    /// </summary>
    public partial class UrlDialog : Form
    {
        private string url;

        public UrlDialog()
        {
            InitializeComponent();
        }

        public string Url
        {
            get
            {
                return url;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            url = urlBox.Lines[0];
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong absolute URL. Please try again.");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
