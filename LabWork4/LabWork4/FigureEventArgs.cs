using System;
using Model;

namespace View
{
    public class FigureEventArgs : EventArgs
    {
        public FigureBase Figure { get; }

        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }
    }
}