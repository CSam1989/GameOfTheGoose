using System.Linq;

namespace Application.Common.Extensions
{
    public static class IntCollectionExtensions
    {
        public static string DiceThrowsToString(this int[] numbers)
        {
            var output = numbers.Aggregate(
                "",
                (current, number) =>
                    current + $"{number}+");

            return output.Substring(0, output.Length - 1);
        }
    }
}