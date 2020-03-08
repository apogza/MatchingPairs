using System;

namespace MatchingPairs
{
    public class CfgMatchingPairsParser : BaseMatchingPairsParser
    {
        private int _currentCharIndex;

        private char _currentChar;

        private bool _hasReachedEnd;

        public CfgMatchingPairsParser(string expression)
            :base(expression)
        {
        }

        public override bool IsExpressionValid()
        {
            bool isValid = true;
            _hasReachedEnd = false;
            _currentCharIndex = 0;

            try
            {
                _currentChar = Expression[_currentCharIndex];
                Expr();
                isValid = _hasReachedEnd;
            }
            catch(Exception ex)
            {
                if (ex is ArgumentException || ex is IndexOutOfRangeException)
                {
                    isValid = false;
                }
                else
                {
                    throw;
                }
            }

            return isValid;
        }

        private void Expr()
        {
            if (_hasReachedEnd || !_pairs.ContainsKey(_currentChar))
            {
                return;
            }
            
            char openingChar = _currentChar;
            char closingChar = _pairs[_currentChar];

            Match(openingChar);
            Expr();
            Match(closingChar);
            Expr();
        }

        private void Match(char expectedChar)
        {
            if (expectedChar != _currentChar || _hasReachedEnd)
            {
                throw new ArgumentException("Bad Expression - Not Matching Parenthesis!");
            }

            SetNextChar();
        }

        private void SetNextChar()
        {
            try
            {
                _currentChar = Expression[++_currentCharIndex];
            }
            catch(IndexOutOfRangeException)
            {
                _hasReachedEnd = true;
            }
        }
    }
}