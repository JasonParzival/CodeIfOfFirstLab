namespace TheFirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smth = 523341;
            string str = smth.ToString();
            var first_eq = (int)Char.GetNumericValue(str[0]) + (int)Char.GetNumericValue(str[1]) + (int)Char.GetNumericValue(str[2]);
            var second_eq = (int)Char.GetNumericValue(str[3]) + (int)Char.GetNumericValue(str[4]) + (int)Char.GetNumericValue(str[5]);
            string message = "";
            if (first_eq == second_eq)
            {
                message = "Заданное число: " + str + " является счастливым!  Первая сумма: " + first_eq + " равна второй сумме: " + second_eq;
            }
            else if (first_eq > second_eq)
            {
                message = "Заданное число: " + str + " не является счастливым!  Первая сумма: " + first_eq + " больше второй суммы: " + second_eq;
            }
            else if (first_eq < second_eq)
            {
                message = "Заданное число: " + str + " не является счастливым!  Первая сумма: " + first_eq + " меньше второй суммы: " + second_eq;
            }

            Console.WriteLine(message);
        }
    }
}
