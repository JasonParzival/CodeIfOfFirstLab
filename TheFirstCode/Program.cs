namespace TheFirstCode
{
    public class Logic
    {
        public static int Get_sum(int smth, int choice) 
        {
            string str = smth.ToString();
            var eq = (int)Char.GetNumericValue(str[choice]) + (int)Char.GetNumericValue(str[choice + 1]) + (int)Char.GetNumericValue(str[choice + 2]);
            return eq;
        }

        public static string Message(int smth, int first, int second)
        {
            string str = smth.ToString();
            string message = "";
            if (first == second)
            {
                message = "Заданное число: " + str + " является счастливым!  Первая сумма: " + first + " равна второй сумме: " + second;
            }
            else if (first > second)
            {
                message = "Заданное число: " + str + " не является счастливым!  Первая сумма: " + first + " больше второй суммы: " + second;
            }
            else if (first < second)
            {
                message = "Заданное число: " + str + " не является счастливым!  Первая сумма: " + first + " меньше второй суммы: " + second;
            }
            return message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var smth = 523341;
            var first_eq = Logic.Get_sum(smth, 0);
            var second_eq = Logic.Get_sum(smth, 3);
            string message = Logic.Message(smth, first_eq, second_eq);       

            Console.WriteLine(message);
        }
    }
}
