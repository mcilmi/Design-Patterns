using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern {
    public class Cell{
        private readonly int _row;
        private readonly int _column;
        private string _content;
        private Formatting _formatting;

        public Cell(int row, int column)
        {
            this._row = row;
            this._column = column;
        }

        public string GetContent()
        {
            return this._content;
        }

        public void SetContent(string content)
        {
            this._content = content;
        }

        public void SetFormatting(Formatting formatting)
        {
            this._formatting = formatting;
        }


        public void Render()
        {
            Console.WriteLine("({0},{1}): {2} [{3}][{4}][{5}]",_row,_column,
                this._content,this._formatting.GetFontFamily(),
                this._formatting.GetFontSize(),
                this._formatting.IsBold());
        }
    }

  
}
