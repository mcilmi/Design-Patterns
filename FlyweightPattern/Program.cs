using System;

namespace FlyweightPattern {
    public class Program {
        public static void Main(string[] args) {
            var formatFactory = new FormatFactory();
            var sheet = new Spreadsheet(4,4,formatFactory);
            sheet.SetContent(0,0,"War");
            sheet.SetContent(1,0,"ma la baryay?");
            sheet.SetContent(2, 0, "Haahey!");
            sheet.SetContent(3, 0, "Gartay");
            sheet.SetFormatting(0,0, formatFactory.GetFormatting(FontFamily.Arial));
            sheet.SetFormatting(1,0, formatFactory.GetFormatting(FontFamily.Roboto, 18, true));
            sheet.SetFormatting(2,0,formatFactory.GetFormatting(FontFamily.Roboto,18, true));
            sheet.SetFormatting(3,0, formatFactory.GetFormatting(FontFamily.Arial));
            sheet.Render();
        }
    }
}
