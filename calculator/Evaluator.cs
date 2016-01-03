using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ExpressionEvaluator
{
       public class Parser
        {
            
           public Parser(string inputExpr)
            {
                validOperators.Add("+", 0);
                validOperators.Add("-", 0);
                validOperators.Add("*", 1);
                validOperators.Add("/", 1);
                validOperators.Add("^", 2);
                validOperators.Add("(", 3);
                validOperators.Add(")", 3);
                association.Add("+", "lefttoright");
                association.Add("-", "lefttoright");
                association.Add("*", "lefttoright");
                association.Add("/", "lefttoright");
                association.Add("^", "righttoleft");
                expression = inputExpr;
            }
            Dictionary<string, int> validOperators = new Dictionary<string, int>();
            Dictionary<string, string> association = new Dictionary<string, string>();
            string expression;
            Stack<string> operators = new Stack<string>();
             public List<string> output = new List<string>();

            public  void toPostifix()
            {
                List<string> newExpression = convertToSplitExp(expression);
                foreach (string s in newExpression)
                {
                    loop(s);
                }
           
                while (operators.Count != 0){
                    output.Add(operators.Pop());
                
                }

                for (int i = 0; i < output.Count; i++) {
                    if (output[i].Equals("(") || output[i].Equals(")"))
                    {
                        output.RemoveAt(i);
                    }
                }
            }
            private void loop (string c)
            {
                int temp;
                    if (int.TryParse(c, out temp))
                    {
                        output.Add(c);
                    }
                    else if (!int.TryParse(c, out temp) && operators.Count == 0 || operators.Peek().Equals("("))
                    {
                        operators.Push(c);
                    }
                    else if (c.Equals("("))
                    {
                
                        operators.Push(c);
                    }
                    else if (c.Equals(")"))
                    {
                            while (operators.Count != 0)
                            {
                                if (operators.Peek().Equals("("))
                                {
                                    operators.Pop();
                                    break;
                                }
                                else
                                {
                                    output.Add(operators.Pop());
                                }
                            }
                    }
                    else if (validOperators[operators.Peek()] < validOperators[c])
                    {
                    operators.Push(c);
                     }
                    else if (validOperators[operators.Peek()] == validOperators[c])
                    {
                        if (association[c].Equals("lefttoright"))
                        {
                        output.Add(" " + operators.Pop());
                            operators.Push(c);
                        }
                        else
                        {
                            operators.Push(c);
                        }
                    }
                    else
                    {
                    output.Add(" " + operators.Pop());
                        loop(c);
                    }
                }


            private List<string> convertToSplitExp(string input)
            {
                List<string> finalres = Regex.Split(input, @"(\d*)").ToList();

                finalres.RemoveAll(s => s.Equals(string.Empty));

                return finalres;
            }
        }
    public class Evaluator
    {
        public Evaluator(List<string> expression)
        {
            Input = expression;
            numbers = new Stack<double>();
        }
        List<string> Input;
        Stack<double> numbers;
        double answer = 0.0;

        public double Evaluate()
        {
            double val;
            double val1;
            double val2;
            foreach (string s in Input)
            {
                if (double.TryParse(s, out val))
                {
                    numbers.Push(val);
                }else
                {
                    switch (s)
                    {
                        case "+":
                            val2 = numbers.Pop();
                            val1 = numbers.Pop();
                            numbers.Push(val1 + val2);
                            break;
                        case "-":
                            val2 = numbers.Pop();
                            val1 = numbers.Pop();
                            numbers.Push(val1 - val2);
                            break;
                        case "*":
                            val2 = numbers.Pop();
                            val1 = numbers.Pop();
                            numbers.Push(val1 * val2);
                            break;
                        case "/":
                            val2 = numbers.Pop();
                            val1 = numbers.Pop();
                            numbers.Push(val1 / val2);
                            break;
                        case "^":
                            val2 = numbers.Pop();
                            val1 = numbers.Pop();
                            numbers.Push(Math.Pow(val1, val2));

                            break;
                    }
                }
            }
            answer = numbers.Pop();
            return answer;
        }
       
    }




    public static class Solver
    {
        public static string Evaluate(string s)
        {
            ExpressionEvaluator.Parser p = new ExpressionEvaluator.Parser(s);
            p.toPostifix();
            ExpressionEvaluator.Evaluator e = new ExpressionEvaluator.Evaluator(p.output);
            return e.Evaluate().ToString();

        }
    }

}


