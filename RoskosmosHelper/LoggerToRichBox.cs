using System;
using System.Windows.Forms;


namespace RoskosmosHelper
{
    public class LoggerToRichBox : ILogger
    {
        private readonly RichTextBox box;

        public LoggerToRichBox(RichTextBox box)
        {
            this.box = box;
            box.Clear();
            WriteLine("LoggerToRichBox init OK");
        }
        public void Clear()
        {
            box.Clear();
        }

        public void NewLine()
        {
            box.AppendText("\n");
        }

        public void WriteLine(string message)
        {
            box.AppendText(DateTime.Now + "   " + message + "\n");
        }

        public void WriteText(string message)
        {
            box.AppendText(DateTime.Now + "   " + message + " ");
        }
    }
}
