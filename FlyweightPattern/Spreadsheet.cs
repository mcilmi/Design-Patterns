using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern {
    public class Spreadsheet {

        private readonly FormatFactory _formatFactory;
        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file
        private readonly Cell[,] _cells;
        private readonly int _maxRows;
        private readonly int _maxCols;
        public Spreadsheet(int maxRows, int maxCols, FormatFactory formatFactory)
        {
            _formatFactory = formatFactory;
            _maxRows = maxRows;
            _maxCols = maxCols;
            _cells = new Cell[maxRows,maxCols];
            GenerateCells();
        }

        public void SetContent(int row, int col, string content) {
            EnsureCellExists(row, col);

            _cells[row,col].SetContent(content);
        }

        public void SetFormatting(int row, int col, Formatting formatting) {
            EnsureCellExists(row, col);

            _cells[row,col].SetFormatting(formatting);
        }

        private void EnsureCellExists(int row, int col) {
            if (row < 0 || row >= _maxRows)
                throw new  ArgumentException();

            if (col < 0 || col >= _maxCols)
                throw new ArgumentException();
        }

        private void GenerateCells() {
            for (var row = 0; row < _maxRows; row++)
            for (var col = 0; col < _maxCols; col++) {
                var cell = new Cell(row, col);
                cell.SetFormatting(this._formatFactory.GetFormatting(FontFamily.TimesNewRoman,12,false));
                _cells[row,col] = cell;
            }
        }

        public void Render() {
            for (var row = 0; row < _maxRows; row++)
            for (var col = 0; col < _maxCols; col++)
                _cells[row,col].Render();
        }
    }
}
