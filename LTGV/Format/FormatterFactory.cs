namespace LTGV.Format
{
    public static class FormatterFactory
    {
        public static AbstractFormatter[] CreateStandartFormatters()
        {
            var formatters = new AbstractFormatter[1];

            formatters[0] = new ReplaceFormatter();

            return formatters;
        }
    }
}