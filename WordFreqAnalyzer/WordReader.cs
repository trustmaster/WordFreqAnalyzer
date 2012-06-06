// WordReader.cs
//using System;
//using Microsoft.Office.Interop.Word;
//using System.Windows.Forms;
//
//namespace TextAnalyzer
//{
//    /// <summary>
//    /// Читает текст из документа Microsoft Word на локальном диске
//    /// </summary>
//    public class WordReader : Reader
//    {
//        public WordReader() : base() { }
//
//        public WordReader(string path) : base(path) { }
//
//        public override string GetText()
//        {
//            try
//            {
//                ApplicationClass msword = new ApplicationClass();
//                object file = path;
//                object nullobj = System.Reflection.Missing.Value;
//                Document doc = msword.Documents.Open(ref file, ref nullobj, ref nullobj,
//                    ref nullobj, ref nullobj, ref nullobj,
//                    ref nullobj, ref nullobj, ref nullobj,
//                    ref nullobj, ref nullobj, ref nullobj,
//                    ref nullobj, ref nullobj, ref nullobj, ref nullobj);
//                doc.ActiveWindow.Selection.WholeStory();
//                doc.ActiveWindow.Selection.Copy();
//                IDataObject data = Clipboard.GetDataObject();
//                string text = data.GetData(DataFormats.Text).ToString();
//                doc.Close(ref nullobj, ref nullobj, ref nullobj);
//                msword.Quit(ref nullobj, ref nullobj, ref nullobj);
//                return text;
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.Message);
//                return "";
//            }
//        }
//    }
//}