using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class TextEditor
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public void OpenFile(string filePath)
        {
            content = File.ReadAllText(filePath);
        }

        public void SaveFile(string filePath)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
