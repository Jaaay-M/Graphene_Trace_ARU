namespace Sensore_Database.Services
{
    public class SensorCsvParser
    {
        public List<int[,]> ParseFrames(string path)
        {
            var lines = File.ReadAllLines(path);
            var frames = new List<int[,]>();

            int frameCount = lines.Length / 32;

            for (int f = 0; f < frameCount; f++)
            {
                int[,] grid = new int[32, 32];

                for (int r = 0; r < 32; r++)
                {
                    var values = lines[f * 32 + r].Split(',');

                    for (int c = 0; c < 32; c++)
                        grid[r, c] = int.Parse(values[c]);
                }

                frames.Add(grid);
            }

            return frames;
        }
    }
}