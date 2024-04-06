using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class SearchFunctionality
{
    public static int FindText(string searchText, string content, int startIndex)
    {
        return content.IndexOf(searchText, startIndex);
    }
}
}
