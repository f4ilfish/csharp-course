using System;
using Model;

namespace View
{
    /// <summary>
    /// FigureEventArgs class
    /// </summary>
    public class FigureEventArgs : EventArgs
    {
        /// <summary>
        /// Added figure auto-prop
        /// </summary>
        public FigureBase Figure { get; }

        /// <summary>
        /// FigureEventArgs instance constructor
        /// </summary>
        /// <param name="figure"></param>
        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }
    }
}