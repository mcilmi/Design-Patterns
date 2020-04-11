using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern {
    public class PointIcon {
        private readonly PointType _type; // 4 bytes
        private readonly byte[] _icon; // 20 KB x 1000 -> 20 MB
        public PointIcon(PointType type, byte[] icon)
        {
            this._type = type;
            this._icon = icon;
        }

        public PointType GetType()
        {
            return this._type;
        }
    }
}
