using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public class TextEditingOperations
    {
        public static string Replace(string text, string searchText, string replaceText)
        {
            return text.Replace(searchText, replaceText);
        }

        public class ToUpperCaseCommand : ICommand
        {
            private RichTextBox textBox;

            public ToUpperCaseCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                
                textBox.SelectedText = textBox.SelectedText.ToUpper();
            }
        }

        public class ToLowerCaseCommand : ICommand
        {
            private RichTextBox textBox;

            public ToLowerCaseCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                // Convertirea textului selecționat în minuscule
                textBox.SelectedText = textBox.SelectedText.ToLower();
            }
        }

        public static string DeleteCurrentLine(string text, int caretIndex)
        {
            int start = text.LastIndexOf(Environment.NewLine, caretIndex - 1);
            int end = text.IndexOf(Environment.NewLine, caretIndex);

            if (start == -1)
                start = 0;
            if (end == -1)
                end = text.Length;

            return text.Remove(start, end - start).Trim();
        }

        public class BoldCommand : ICommand
        {
            private RichTextBox textBox;

            public BoldCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                textBox.SelectionFont = new Font(textBox.Font, FontStyle.Bold);
            }
        }

        public class AlignLeftCommand : ICommand
        {
            private RichTextBox textBox;

            public AlignLeftCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                
                textBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        public class ItalicCommand : ICommand
        {
            private RichTextBox textBox;

            public ItalicCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                textBox.SelectionFont = new Font(textBox.Font, FontStyle.Italic);
            }
        }

        public class UnderlineCommand : ICommand
        {
            private RichTextBox textBox;

            public UnderlineCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                textBox.SelectionFont = new Font(textBox.Font, FontStyle.Underline);
            }
        }

        public class AlignCenterCommand : ICommand
        {
            private RichTextBox textBox;

            public AlignCenterCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                textBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public class AlignRightCommand : ICommand
        {
            private RichTextBox textBox;

            public AlignRightCommand(RichTextBox textBox)
            {
                this.textBox = textBox;
            }

            public void Execute()
            {
                textBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }


    }
}
