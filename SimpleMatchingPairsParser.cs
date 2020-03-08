using System.Collections.Generic;

namespace MatchingPairs
{
    public class SimpleMatchingPairsParser : BaseMatchingPairsParser
    {
        public SimpleMatchingPairsParser(string expression)
            : base(expression)
        {
        }

        public override bool IsExpressionValid()
        {
            bool isExpressionValid = true;

            Stack<char> closingChars = new Stack<char>();

            foreach (char currentChar in Expression)
            {
                if (_pairs.ContainsKey(currentChar))
                {
                    closingChars.Push(_pairs[currentChar]);
                }
                else
                {
                    if (!closingChars.TryPop(out char closingChar)
                        || currentChar != closingChar)
                    {
                        isExpressionValid = false;
                        break;
                    }
                }
            }

            isExpressionValid = isExpressionValid && closingChars.Count == 0;

            return isExpressionValid;
        }
    }
}