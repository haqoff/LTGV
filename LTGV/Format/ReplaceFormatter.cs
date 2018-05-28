using System;

namespace LTGV.Format
{
    public class ReplaceFormatter : AbstractFormatter
    {
        public const string USAGE = "{ВЫРАЖЕНИЕ}{ЗАМЕНА}";

        private string input;
        private string replacement;

        public ReplaceFormatter()
            : base("Замена", USAGE)
        {
        }

        public override void ParseCommand()
        {
            if (!CbEnabled.Checked) return;
            if (CbEnabled.Checked && TbCommand.Text.Length == 0)
                throw new FormatException($"{LblName.Text} не содержит команд.");

            var t = TbCommand.Text;
            var exceptionMsg = $"Функция {LblName.Text} содержит неправильную команду.\nИспользование: {USAGE}";

            var first = t[0] == '{' ? 0 : throw new FormatException(exceptionMsg);
            var last = t[t.Length - 1] == '}' ? t.Length - 1 : throw new FormatException(exceptionMsg);

            var middle = t.IndexOf("}{");
            if (middle == -1) throw new FormatException(exceptionMsg);

            input = t.Substring(first + 1, middle - 1);
            if(input=="") throw  new FormatException($"{LblName.Text} не может содержать пустое выражение.");

            replacement = t.Substring(middle + 2, last - middle - 2);
        }

        public override string Format(string source)
        {
            return source.Replace(input, replacement);
        }
    }
}