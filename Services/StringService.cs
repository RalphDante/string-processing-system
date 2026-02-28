namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _currentText;
        private string _originalText;

        public StringService()
        {
            _currentText = string.Empty;
            _originalText = string.Empty;
        }

        public void SetText(string text)
        {
            _currentText = text;
            if (string.IsNullOrEmpty(_originalText))
            {
                _originalText = text;
            }
        }

        public string GetCurrentText()
        {
            return _currentText;
        }

        public string ConvertToUppercase()
        {
            _currentText = _currentText.ToUpper();
            return _currentText;
        }

        public string ConvertToLowercase()
        {
            _currentText = _currentText.ToLower();
            return _currentText;
        }

        public int CountCharacters()
        {
            return _currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return _currentText.Contains(word);
        }

        public string ReplaceWord(string oldWord, string newWord)
        {
            _currentText = _currentText.Replace(oldWord, newWord);
            return _currentText;
        }

        public string ExtractSubstring(int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= _currentText.Length)
            {
                return "Invalid start index.";
            }

            if (startIndex + length > _currentText.Length)
            {
                length = _currentText.Length - startIndex;
            }

            _currentText = _currentText.Substring(startIndex, length);
            return _currentText;
        }

        public string TrimSpaces()
        {
            _currentText = _currentText.Trim();
            return _currentText;
        }

        public string ResetText()
        {
            _currentText = _originalText;
            return _currentText;
        }

        public bool IsTextEmpty()
        {
            return string.IsNullOrEmpty(_currentText);
        }
    }
}
