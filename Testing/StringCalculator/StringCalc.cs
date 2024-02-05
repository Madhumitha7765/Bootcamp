using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorLib
{
    public class StringCalculator
    {
        public static int Add(string numbers) =>
            string.IsNullOrEmpty(numbers) ? 0 : GetSum(numbers);

        private static int GetSum(string numbers)
        {
            var (delimiter, newNumbers) = GetDelimiterAndNumbers(numbers);

            return ContainsAny(numbers, delimiter)
                ? SumNumbers(newNumbers, delimiter)
                : ParseToInt(newNumbers);
        }

        private static (string Delimiter, string NewNumbers) GetDelimiterAndNumbers(string numbers)
        {
            if (HasSpecificDelimiter(numbers))
            {
                var specificDelimiters = GetSpecificDelimiters(numbers);
                var specificNumbers = GetSpecificNumbers(numbers);
                return (string.Join("|", specificDelimiters.Select(Regex.Escape)), specificNumbers);
            }

            return (",|\n", numbers);
        }

        private static bool HasSpecificDelimiter(string numbers) => numbers.StartsWith("//");

        private static string[] GetSpecificDelimiters(string numbers) =>
            Regex.Matches(numbers, @"\[([^\]]+)\]")
                .Cast<Match>()
                .Select(m => m.Groups[1].Value)
                .ToArray();

        private static string GetSpecificNumbers(string numbers) =>
            numbers.Substring(numbers.IndexOf('\n') + 1,
                numbers.Length - numbers.IndexOf('\n') - 1);

        private static int SumNumbers(string numbers, string delimiter) =>
            numbers.Split(delimiter.ToCharArray())
                .Where(n => !IsGreaterThanThousand(Convert.ToInt32(n)))
                .Sum(ParseToInt);

        private static int ParseToInt(string n) => Convert.ToInt32(string.IsNullOrEmpty(n) ? "0" : n);

        private static bool IsGreaterThanThousand(int nn) => nn > 1000;

        private static bool ContainsAny(string input, string getPossibleDelimiters) =>
            getPossibleDelimiters.ToCharArray().Any(input.Contains);
    }
}
