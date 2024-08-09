using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YrFit.Controller
{
    public static class Validator
    {
        public static Regex loginRegex = new Regex(@"^[А-Яа-яA-Za-z][А-Яа-яA-Za-z\d_.]{0,19}$");
        public static Regex nameRegex = new Regex(@"^[А-Яа-яЁёA-Za-z \-]+$");
        public static Regex phoneRegex = new Regex(@"^(\+375-|80-)(25-|29-|33-|44-)(\d{3}-\d{2}-\d{2})$");
        public static Regex eMailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

        public static (bool isValid, List<string> forbiddenSymbols) Validate(string value, Regex regex)
        {
            if (regex.IsMatch(value))
                return (true, null);

            return (false, value.ToCharArray()
                .Where(symbol => !regex.IsMatch(symbol.ToString()))
                .Select(symbol => symbol.ToString()).ToList());
        }

        public static string JoinSymbols(List<string> symbols) => "\"" + string.Join("\", \"", symbols.Distinct()) + "\"";


    }
}
