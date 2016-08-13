using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Room
    {
        private double _floorArea;
        private int _numberBoxesRequiredToTile;

        public int Length { get; }
        public int Width { get; }


        public Room(int length, int width)
        {
            this.Length = length;
            this.Width = width;
            this._calculateFloorArea();
            this._calculateNumberBoxesTiles();
        }

        private void _calculateFloorArea()
        {
            this._floorArea = this.Length * this.Width;
        }

        /**
         * <summary>
         * This method calculates the number of boxes of tile needed
         * to tile the room. A room requires one box of tile for every
         * 12 full square feet plus a box for any partial square footage
         * over 12, plus one extra box for waste from irregular cuts.
         * </summary>
         * 
         * @private
         * @method _calculateNumberBoxesTiles
         * @returns {void}
         */
        private void _calculateNumberBoxesTiles()
        {
            int fullSqFtBoxes = Convert.ToInt32(this._floorArea / 12);
            int extraSqFtBox = (this._floorArea % 12 != 0) ? 1 : 0;
            this._numberBoxesRequiredToTile = fullSqFtBoxes + extraSqFtBox + 1;
        }

        public override string ToString()
        {
            return string.Format("Length: {0}\nWidth: {1}\nArea: {2}\nNumber Boxes Tiles Needed: {3}",
                this.Length, this.Width, this._floorArea, this._numberBoxesRequiredToTile);
        }
    }
}
