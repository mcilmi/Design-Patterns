using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern {
    public class PointService
    {
        private readonly PointIconFactory _pointIconFactory;
        private readonly List<Point> _points = new List<Point>();

        public PointService(PointIconFactory pointIconFactory)
        {
            this._pointIconFactory = pointIconFactory;
        }

        public List<Point> GetPoints()
        {
            var point = new Point(0, 0, this._pointIconFactory.GetPointIcon(PointType.CAFE));
            this._points.Add(point);

            return this._points;
        }
    }
}
