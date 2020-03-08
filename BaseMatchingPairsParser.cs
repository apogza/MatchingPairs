using System.Collections.Generic;

namespace MatchingPairs
{
    public abstract class BaseMatchingPairsParser
    {
        protected Dictionary<char, char> _pairs;

        public string Expression { get; }
        public BaseMatchingPairsParser(string expression)
        {
            Expression = expression;
            InitMatchingPairsDictionary();
        }

        private void InitMatchingPairsDictionary()
        {
            _pairs = new Dictionary<char, char>
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };
        }

        public abstract bool IsExpressionValid();
    }
}