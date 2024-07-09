namespace MyWebApplication1
{
    public class ResultStringService
    {
        public List<string> SeperatedByComas(InputString input)
        {
            var values = input.Value.Split(',').Select(v => v.Trim()).ToList();
            return values;
        }
    }
}
