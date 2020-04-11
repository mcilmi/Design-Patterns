using System;

namespace FlyweightPattern {
    public class Point {
        private int _x; // 4 bytes
        private int _y; // 4 bytes
        private PointIcon _icon;
        public Point(int x, int y, PointIcon icon) {
            this._x = x;
            this._y = y;
            this._icon = icon;
        }

        public void Draw() {
            Console.WriteLine("{0} at ({1:D},{2:D})", this._icon.GetType(), _x, _y);
        }
    }
}
