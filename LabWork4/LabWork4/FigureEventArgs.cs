using System;
using Model;

namespace View
{
    //TODO: XML
    public class FigureEventArgs : EventArgs
    {
        public FigureBase Figure { get; }

        public FigureEventArgs(FigureBase figure)
        {
            Figure = figure;
        }
    }
}