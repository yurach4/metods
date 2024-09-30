/*1 завдання (калькулятор)
public static double Calculator(double operand1, double operand2, string operation)
{
    switch (operation)
    {
        case "+":
            return operand1 + operand2;
        case "-":
            return operand1 - operand2;
        case "*":
            return operand1 * operand2;
        case "/":
            if (operand2 == 0)
                throw new DivideByZeroException("Ділення на нуль!");
            return operand1 / operand2;
        default:
            throw new ArgumentException("Невідома операція");
    }
}

2 завдання (перевірка простого числа)
public static bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;
    }
    return true;
}

3 завдання( конвертація валют) (public static double ConvertCurrency(double amount, double exchangeRate)
{
    return amount * exchangeRate;
}

4 завдання(пошуки найбільшого і найменшого значень)
public static (int min, int max) FindMinMax(int[] array)
{
    if (array == null || array.Length == 0)
        throw new ArgumentException("Масив не може бути порожнім");
    
    int min = array[0];
    int max = array[0];
    
    foreach (var number in array)
    {
        if (number < min) min = number;
        if (number > max) max = number;
    }
    
    return (min, max);
}

5 завдання(робота з рядками)
public static (int vowels, int consonants) CountVowelsAndConsonants(string input)
{
    int vowelsCount = 0;
    int consonantsCount = 0;
    
    foreach (char c in input.ToLower())
    {
        if (char.IsLetter(c))
        {
            if ("aeiou".Contains(c))
                vowelsCount++;
            else
                consonantsCount++;
        }
    }
    
    return (vowelsCount, consonantsCount);
}

6 завдання(геометричний калькулятор)
public static (double area, double volume) GeometryCalculator(string shape, double dimension1, double dimension2 = 0)
{
    switch (shape.ToLower())
    {
        case "circle":
            return (Math.PI * dimension1 * dimension1, 0);
        case "rectangle":
            return (dimension1 * dimension2, 0);
        case "cube":
            return (0, Math.Pow(dimension1, 3));
        default:
            throw new ArgumentException("Невідома геометрична фігура");
    }
}
