using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace FlyweightPattern {
    public class FormatFactory {
        private readonly Dictionary<string, Formatting> _formatting = new Dictionary<string, Formatting>();

        public Formatting GetFormatting(FontFamily fontFamily = FontFamily.TimesNewRoman, int fontSize = 12, bool isBold = false )
        {
            // Key -> Value (Key: Formatting)
            var key = fontFamily.ToString() + fontSize.ToString() + isBold.ToString();
            var hasKey = this._formatting.TryGetValue(key, out var result);
            // Console.WriteLine("key {0} hasKey: {1}", key, hasKey);
            if (hasKey) return result;
            var newFormatting = new Formatting(fontFamily,fontSize, isBold);
            this._formatting.Add(key, newFormatting);

            return newFormatting;
        }

    }

   
}
