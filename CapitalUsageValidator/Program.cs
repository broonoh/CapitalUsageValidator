using System;
using CapitalUsageValidator;

class Program {
    static void Main() {
        // Usando um nome alternativo para a instância
        Solution validator = new Solution();
        
        // Exemplo 1
        Console.WriteLine(validator.DetectCapitalUse("USA")); // Saída: true
        
        // Exemplo 2
        Console.WriteLine(validator.DetectCapitalUse("FlaG")); // Saída: false
        
        // Exemplo 3
        Console.WriteLine(validator.DetectCapitalUse("Google")); // Saída: true
        
        // Exemplo 4
        Console.WriteLine(validator.DetectCapitalUse("leetcode")); // Saída: true
    }
}