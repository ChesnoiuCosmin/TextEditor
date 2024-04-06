using TextEditor;

namespace TextEditorTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReplaceFunctionality_ReplaceText_Success()
        {
            // Arrange
            string searchText = "Lorem";
            string replaceText = "Hello";
            string content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int index = content.IndexOf(searchText); 

            // Act
            string result = content; 
            ReplaceFunctionality.ReplaceText(searchText, replaceText, ref result, index, searchText.Length);

            // Assert
            Assert.Equal("Hello ipsum dolor sit amet, consectetur adipiscing elit.", result);
        }

        [Fact]
        public void SearchFunctionality_FindText_Success()
        {
            // Arrange
            string searchText = "Lorem";
            string content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            // Act
            int result = SearchFunctionality.FindText(searchText, content, 0);

            // Assert
            Assert.Equal(0, result); // Expecting 'Lorem' to be found at index 0
        }

    }
}