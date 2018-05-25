namespace LTGV.Format
{
    class ReplaceFormatter : AbstractFormatter
    {
        public ReplaceFormatter()
            : base("Заменить", "Usage: {\"Выражение\"\"Замена\"}")
        {
        }

        public override string Format(string source)
        {
            return source.Replace(" ", "");//TODO
        }
    }
}
