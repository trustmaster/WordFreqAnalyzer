// HttpReader.cs
using System.Text;
using System.IO;
using System.Net;

namespace TextAnalyzer
{
    /// <summary>
    /// Receives document text via HTTP
    /// </summary>
    public class HttpReader : Reader
    {
        public HttpReader() : base() { }

        public HttpReader(string url) : base(url) { }

        public override string GetText()
        {
            string text = "";
            HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(path);
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.ContentType.Contains("text/html"))
                    {
                        // text/html only
                        Encoding enc = response.ContentEncoding == "" ? Encoding.UTF8 : Encoding.GetEncoding(response.ContentEncoding);
                        StreamReader sr = new StreamReader(response.GetResponseStream(), enc);
                        text = sr.ReadToEnd();
                        sr.Close();
                        response.Close();
                    }
                }
            }
            catch (WebException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return "";
            }
            return text;
        }
    }
}
