using System;

namespace MatchingPairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = "{(([{}]))}[()]";
            CfgMatchingPairsParser parser = new CfgMatchingPairsParser(parenthesis);
            Console.WriteLine("Is expression {0}? {1}", parenthesis, parser.IsExpressionValid());

            SimpleMatchingPairsParser simpleParser = new SimpleMatchingPairsParser(parenthesis);
            Console.WriteLine("Is expression {0}? {1}", parenthesis, simpleParser.IsExpressionValid());
        }
    }
}
