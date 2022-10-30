namespace MyWebApp.Models
{
    public class TextModel
    {
        public string InText { get; set; }
        public string OutText { get; set; }

        public override string ToString()
        {
            return $"InText='{InText}' OutText='{OutText}'";
        }
    }
}
