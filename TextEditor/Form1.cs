using System;
using System.Drawing;
using System.Windows.Forms;
using static TextEditor.TextEditingOperations;

namespace TextEditor
{
    public partial class TextEditorForm : Form
    {
        private TextEditor textEditor;
        private bool UpperCaseButtonPressed = false;
        private bool LowerCaseButtonPressed = false;
        private int lastFoundIndex = -1;
        private CommandManager commandManager = new CommandManager();

        public TextEditorForm()
        {
            InitializeComponent();
            textEditor = new TextEditor();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textEditor.OpenFile(filePath);
                textBoxContent.Text = textEditor.Content;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                textEditor.Content = textBoxContent.Text;
                textEditor.SaveFile(filePath);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text;
            int startIndex = lastFoundIndex != -1 ? lastFoundIndex + 1 : 0;
            int index = SearchFunctionality.FindText(searchText, textBoxContent.Text, startIndex);

            if (index != -1)
            {
                textBoxContent.SelectionStart = index;
                textBoxContent.SelectionLength = searchText.Length;
                lastFoundIndex = index;
                textBoxContent.Focus();
            }
            else
            {
                if (lastFoundIndex != -1)
                {
                    lastFoundIndex = -1;
                    searchButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Textul căutat nu a fost găsit.", "Căutare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text;
            string replaceText = replaceTextbox.Text;

            int index = textBoxContent.SelectionStart;
            int length = textBoxContent.SelectionLength;
            string selectedText = textBoxContent.SelectedText;

            if (!string.IsNullOrEmpty(selectedText) && selectedText == searchText)
            {
                if (ReplaceFunctionality.ReplaceText(searchText, replaceText, ref selectedText, 0, selectedText.Length))
                {
                    textBoxContent.SelectedText = selectedText;
                    textBoxContent.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nu a fost găsit niciun text selectat pentru înlocuire.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toUpperCaseButton_Click(object sender, EventArgs e)
        {
            ICommand toUpperCaseCommand = new ToUpperCaseCommand(textBoxContent);
            commandManager.ExecuteCommand(toUpperCaseCommand);
        }

        private void toLowerCaseButton_Click(object sender, EventArgs e)
        {
            ICommand toLowerCaseCommand = new ToLowerCaseCommand(textBoxContent);
            commandManager.ExecuteCommand(toLowerCaseCommand);
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            ICommand boldCommand = new BoldCommand(textBoxContent);
            commandManager.ExecuteCommand(boldCommand);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            ICommand italicCommand = new ItalicCommand(textBoxContent);
            commandManager.ExecuteCommand(italicCommand);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            ICommand underlineCommand = new UnderlineCommand(textBoxContent);
            commandManager.ExecuteCommand(underlineCommand);
        }

        private void alignLeftButton_Click(object sender, EventArgs e)
        {
            ICommand alignLeftCommand = new AlignLeftCommand(textBoxContent);
            commandManager.ExecuteCommand(alignLeftCommand);
        }

        private void alignCenterButton_Click(object sender, EventArgs e)
        {
            ICommand alignCenterCommand = new AlignCenterCommand(textBoxContent);
            commandManager.ExecuteCommand(alignCenterCommand);
        }

        private void alignRightButton_Click(object sender, EventArgs e)
        {
            ICommand alignRightCommand = new AlignRightCommand(textBoxContent);
            commandManager.ExecuteCommand(alignRightCommand);
        }
        private void textBoxContent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (textBoxContent.SelectionLength > 0)
                {
                    string selectedText = textBoxContent.SelectedText;
                    if (!string.IsNullOrEmpty(selectedText))
                    {
                        if (UpperCaseButtonPressed)
                        {
                            textBoxContent.SelectedText = selectedText.ToUpper();
                        }
                        else if (LowerCaseButtonPressed)
                        {
                            textBoxContent.SelectedText = selectedText.ToLower();
                        }
                    }
                }
            }
        }
        


        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {
            UpperCaseButtonPressed = false;
            LowerCaseButtonPressed = false;
        }
    }
}
