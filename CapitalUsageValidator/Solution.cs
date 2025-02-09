namespace CapitalUsageValidator;

public class Solution
{
    public bool DetectCapitalUse(string word) {
        // Verifica se todas as letras são maiúsculas
        if (word == word.ToUpper()) {
            return true;
        }
        
        // Verifica se todas as letras são minúsculas
        if (word == word.ToLower()) {
            return true;
        }
        
        // Verifica se apenas a primeira letra é maiúscula
        if (word.Length > 0 && char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower()) {
            return true;
        }
        
        // Se nenhuma das condições acima for atendida, retorna false
        return false;
    }
}