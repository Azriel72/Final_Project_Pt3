namespace MyWebApplication1
{
    public class InputString
    {
        public string Value { get; private set; }

        public InputString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("The string cannot be null or empty");
            }

            Value = input;
        }
    }
}
