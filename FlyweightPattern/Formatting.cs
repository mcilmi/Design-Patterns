using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern {
    public class Formatting
    {
        private readonly FontFamily _fontFamily;
        private readonly int _fontSize;
        private readonly bool _isBold;

        public Formatting(FontFamily fontFamily = FontFamily.TimesNewRoman, int fontSize = 12, bool isBold = false)
        {
            this._fontFamily = fontFamily;
            this._fontSize = fontSize;
            this._isBold = isBold;
        }

        public FontFamily GetFontFamily()
        {
            return this._fontFamily;
        }

        public int GetFontSize()
        {
            return this._fontSize;
        }

        public bool IsBold()
        {
            return this._isBold;
        }
    }
}
