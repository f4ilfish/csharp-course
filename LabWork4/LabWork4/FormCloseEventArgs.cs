using System;

namespace View
{
    /// <summary>
    /// FormCloseEventArgs class
    /// </summary>
    public class FormCloseEventArgs : EventArgs
    {
        /// <summary>
        /// Form closed auto-prop
        /// </summary>
        public bool IsFormClosed { get; }

        /// <summary>
        /// FormCloseEventArgs instance constructor
        /// </summary>
        /// <param name="isFormClosed"></param>
        public FormCloseEventArgs(bool isFormClosed)
        {
            IsFormClosed = isFormClosed;
        }
    }
}