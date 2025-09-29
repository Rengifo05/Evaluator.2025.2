using System;
using System.Collections.Generic;
using System.Globalization;

namespace Evaluator.Core
{
    public class ExpressionEvaluator
    {
        public static double Evaluate(string infix)
        {
            var tokens = Tokenize(infix);
            var postfix = InfixToPostfix(tokens);
            return Calculate(postfix);
        }
        private static List<string> Tokenize(string expr)
        {
            var tokens = new List<string>();
            string number = "";

            foreach (char c in expr)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else if (IsOperator(c))
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    tokens.Add(c.ToString());
                }
                else if (!char.IsWhiteSpace(c))
                {
                    throw new Exception($"Carácter no válido: {c}");
                }
            }

            if (!string.IsNullOrEmpty(number))
                tokens.Add(number);

            return tokens;
        }
        private static List<string> InfixToPostfix(List<string> tokens)
        {
            var stack = new Stack<string>();
            var output = new List<string>();

            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    output.Add(token);
                }
                else if (IsOperator(token[0]))
                {
                    if (token == ")")
                    {
                        while (stack.Peek() != "(")
                            output.Add(stack.Pop());
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Count > 0 && PriorityInfix(token[0]) <= PriorityStack(stack.Peek()[0]))
                            output.Add(stack.Pop());

                        stack.Push(token);
                    }
                }
            }

            while (stack.Count > 0)
                output.Add(stack.Pop());

            return output;
        }
        private static double Calculate(List<string> postfix)
        {
            var stack = new Stack<double>();

            foreach (var token in postfix)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(token[0]))
                {
                    var op2 = stack.Pop();
                    var op1 = stack.Pop();
                    stack.Push(Calculate(op1, token[0], op2));
                }
            }

            return stack.Peek();
        }
        private static double Calculate(double op1, char op, double op2) => op switch
        {
            '*' => op1 * op2,
            '/' => op1 / op2,
            '^' => Math.Pow(op1, op2),
            '+' => op1 + op2,
            '-' => op1 - op2,
            _ => throw new Exception("Operador inválido."),
        };
        private static bool IsOperator(char c) => c is '+' or '-' or '*' or '/' or '^' or '(' or ')';

        private static int PriorityInfix(char op) => op switch
        {
            '^' => 4,
            '*' or '/' => 2,
            '+' or '-' => 1,
            '(' => 0,
            _ => throw new Exception("Operador inválido."),
        };

        private static int PriorityStack(char op) => op switch
        {
            '^' => 3,
            '*' or '/' => 2,
            '+' or '-' => 1,
            '(' => 0,
            _ => throw new Exception("Operador inválido."),
        };
    }
}