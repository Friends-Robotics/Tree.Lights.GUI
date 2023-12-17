using FslGift.Serialization;
using System.Threading.Tasks.Sources;

namespace Tree_Gui.Model; 
internal static class DataManager {

    public static List<TreePoint> LedPoints { get; private set; } = new List<TreePoint>();
    public static List<TreePoint> CornerPoints { get; private set; } = new List<TreePoint>();

    public static void AddLedPoint(Rectangle rectangle) {
        LedPoints.Add(Normalise(rectangle));
    }

    public static void AddCornerPoint(Rectangle rectangle) {
        CornerPoints.Add(Normalise(rectangle));
    }

    private static TreePoint Normalise(Rectangle rectangle) {
        return new TreePoint {
            X = (decimal)rectangle.X / rectangle.Width,
            Y = (decimal)rectangle.Y / rectangle.Height
        };
    }

    public struct TreePoint {
        public decimal X {  get; set; }
        public decimal Y { get; set; }
    }
}
