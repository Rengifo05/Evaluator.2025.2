using Evaluator.Core;

class Program
{
    static void Main()
    {
        Console.WriteLine("Evaluador de Funciones\n");
        string[] ejemplos = { "12.5+3.7*2", "(10+2)*3", "2^3+4", "100/25+0.5" };
        foreach (var expr in ejemplos)
        {
            try
            {
                double resultado = ExpressionEvaluator.Evaluate(expr);
                Console.WriteLine($"{expr} = {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{expr} -> Error: {ex.Message}");
            }
        }
        Console.WriteLine("\nPrueba manual:");
        Console.Write("Ingrese una expresión: ");
        string entrada = Console.ReadLine() ?? "";
        try
        {
            double resultado = ExpressionEvaluator.Evaluate(entrada);
            Console.WriteLine($"Resultado = {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
