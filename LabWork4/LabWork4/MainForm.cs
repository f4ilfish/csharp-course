using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Class main form
    /// </summary>
    public partial class MainForm : Form
    {
        //TODO: field
        /// <summary>
        /// Figures list field's property
        /// </summary>
        private BindingList<FigureBase> _figureList = new();

        /// <summary>
        /// Main form instance constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FigureDataGridView.DataSource = _figureList;
        }

        /// <summary>
        /// Event AddFigureButton click
        /// </summary>
        /// <param name="sender">AddFigureButton</param>
        /// <param name="e">Event argument</param>
        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();

            newInputForm.Owner = this;

            newInputForm.Show();

            newInputForm.FigureAdded += (_, args) =>
            {
                _figureList.Add(args.Figure);
            };

            newInputForm.FormClosed += (_, args) =>
            {
                if (args.IsFormClosed)
                {
                    AddFigureButton.Enabled = true;
                }
            };

            AddFigureButton.Enabled = false;
        }

        //TODO: XML
        /// <summary>
        /// Event RemoveFigureButton click
        /// </summary>
        /// <param name="sender">RemoveFigureButton</param>
        /// <param name="e">Event argument</param>
        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if (FigureDataGridView.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in FigureDataGridView.SelectedRows)
                {
                    _figureList.Remove(row.DataBoundItem as FigureBase);
                }
            }
            else
            {
                MessageBox.Show(@"No selected items");
            }
        }
    }
}
