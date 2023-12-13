namespace Day02
{
    internal static class Part1
    {
        internal static void Run()
        {
            var gameInfos = new List<GameInfo>();

            using var reader = new StreamReader("Input.txt");

            while (reader.ReadLine() is string line)
            {
                var gameIdAndGameRecordSplit = line.Split(':');
                var gameInfo = new GameInfo()
                {
                    Id = int.Parse(gameIdAndGameRecordSplit[0][5..])
                };

                var rounds = gameIdAndGameRecordSplit[1].Split(";");
                foreach (var round in rounds)
                {
                    var colorCounts = round.Split(',');
                    foreach (var colorCount in colorCounts)
                    {
                        if (colorCount.Contains("green"))
                        {
                            gameInfo.MaxGreen = int.Parse(colorCount.Trim().Split(' ')[0]);
                        }
                        else if (colorCount.Contains("blue"))
                        {
                            gameInfo.MaxBlue = int.Parse(colorCount.Trim().Split(' ')[0]);
                        }
                        else
                        {
                            gameInfo.MaxRed = int.Parse(colorCount.Trim().Split(' ')[0]);
                        }
                    }
                }

                gameInfos.Add(gameInfo);
            }

            var sumOfPossibleGameIds = gameInfos
                .Where(x => x.MaxGreen <= 13 && x.MaxBlue <= 14 && x.MaxRed <= 12)
                .Select(x => x.Id)
                .Sum();

            Console.WriteLine(sumOfPossibleGameIds);
        }
    }
}
