namespace Sensore_Database.Models
{
     public class SensorFrame
    {
        public int FrameIndex { get; set; }
        public int[,] Matrix { get; set; } = new int[32, 32];
    }
}