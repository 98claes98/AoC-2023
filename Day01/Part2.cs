namespace Day01
{
    internal static class Part2
    {
        internal static void Run()
        {
            var calibrationValuesDictionary = new Dictionary<string, string>() {
                { "one", "1" }, { "two", "2" }, { "three", "3" }, { "four", "4" }, { "five", "5" }, { "six", "6" }, { "seven", "7" }, { "eight", "8" }, { "nine", "9" },
                { "1", "1" }, { "2", "2" }, { "3", "3" }, { "4", "4" }, { "5", "5" }, { "6", "6" }, { "7", "7" }, { "8", "8" }, { "9", "9" }
            };

            using var reader = new StreamReader("Input.txt");

            var total = 0;

            while (reader.ReadLine() is string line)
            {
                var firstIndex = int.MaxValue;
                var firstNum = string.Empty;

                var lastIndex = int.MinValue;
                var lastNum = string.Empty;

                foreach (var keyValuePair in calibrationValuesDictionary)
                {
                    var firstIndexInLine = line.IndexOf(keyValuePair.Key);
                    if (firstIndexInLine != -1 && firstIndexInLine < firstIndex)
                    {
                        firstIndex = firstIndexInLine;
                        firstNum = keyValuePair.Value;
                    }

                    var lastIndexInLine = line.LastIndexOf(keyValuePair.Key);
                    if (lastIndexInLine != -1 && lastIndexInLine > lastIndex)
                    {
                        lastIndex = lastIndexInLine;
                        lastNum = keyValuePair.Value;
                    }
                }

                total += int.Parse(string.Concat(firstNum, lastNum));
            }

            Console.WriteLine(total);
        }
    }
}
