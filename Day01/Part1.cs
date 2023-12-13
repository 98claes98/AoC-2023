namespace Day01
{
    internal static class Part1
    {
        internal static void Run()
        {
            using var reader = new StreamReader("Input.txt");

            var total = 0;

            while (reader.ReadLine() is string line)
            {
                var num1 = line.First(char.IsDigit);
                var num2 = line.Last(char.IsDigit);

                total += int.Parse(string.Concat(num1, num2));
            }

            Console.WriteLine(total);
        }
    }
}
