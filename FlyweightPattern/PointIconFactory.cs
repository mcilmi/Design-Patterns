using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern {
    public class PointIconFactory {
        private readonly Dictionary<PointType,PointIcon> _icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            // key -> value (PointType : PointIcon)
            var hasKey = this._icons.TryGetValue(type, out var result);
            if (hasKey) return result;
            var icon = new PointIcon(type, null);
            _icons.Add(type, icon);

            return icon;
        }
    }
}
