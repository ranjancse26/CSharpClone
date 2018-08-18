using System;

namespace CSharpClone
{
    /// <summary>
    /// Reused code from https://www.dotnetperls.com/clone
    /// </summary>
    class Rock : ICloneable
    {
        int _weight;
        bool _round;
        bool _mossy;

        public Rock(int weight, bool round, bool mossy)
        {
            this._weight = weight;
            this._round = round;
            this._mossy = mossy;
        }

        public object Clone()
        {
            return new Rock(this._weight, this._round, this._mossy);
        }

        public override string ToString()
        {
            return string.Format("weight = {0}, round = {1}, mossy = {2}",
                this._weight,
                this._round,
                this._mossy);
        }
    }
}
