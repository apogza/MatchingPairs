# Matching Pairs

This is a small application that is capable of parsing an expression of matching brackets and/or parenthesis
and tell if the expression is correct. Examples of such expressions are the following:

*()
*(())
*([])
*{[()]}[]

## Implementations

There are two parser implementations. The parser CfgMatchingParisParser uses a context-free grammar approach to test he input.
The grammar that it implements is the following: 

* expr -> terminal expr terminal expr | E
* terminal -> ( | ) | [ | ] | { | }

The second implementation is the SimpleMatchingPairsParser. It does all the verifications using a simple stack to keep track
of the opening and closing symbols.

### Prerequisites

The program is written using .NET Core 2.2.

## License

This project is licensed under the MIT License.