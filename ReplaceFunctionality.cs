using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class ReplaceFunctionality
    {
        public static bool ReplaceText(string searchText, string replaceText, ref string content, int index, int length)
        {
            if (index != -1)
            {
                content = content.Remove(index, length);
                content = content.Insert(index, replaceText);
                return true;
            }
            return false;
        }
    }
}
