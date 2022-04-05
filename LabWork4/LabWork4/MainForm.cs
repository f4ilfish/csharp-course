using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Class main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Figures list
        /// </summary>
        private List<FigureBase> _figureList = new();

        /// <summary>
        /// Figures list field's property
        /// </summary>
        public List<FigureBase> FigureList
        {
            get => _figureList;
            set => _figureList = value;
        }

        /// <summary>
        /// Main form instance constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FigureDataGridView.DataSource = FigureList;
        }

        /// <summary>
        /// Event AddFigureButton click
        /// </summary>
        /// <param name="sender">AddFigureButton</param>
        /// <param name="e">Event argument</param>
        private void AddFigureButton_Click(object sender, System.EventArgs e)
        {
            InputForm newInputForm = new InputForm();

            newInputForm.Show();
        }
    }
}
