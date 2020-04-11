using System;

namespace FlyweightPattern {
    public class Program {
        public static void Main(string[] args) {
            var pointIconfactory = new PointIconFactory();
            var pointService = new PointService(pointIconfactory);

            foreach (var point in pointService.GetPoints()) {
                point.Draw();
            }
        }
    }
}
