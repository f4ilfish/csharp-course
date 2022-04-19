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
        /// <summary>
        /// Figures list
        /// </summary>
        private BindingList<FigureBase> _figureList = new();

        /// <summary>
        /// Figures list field's property
        /// </summary>
        public BindingList<FigureBase> FigureList
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

            newInputForm.FigureAdded += (o, args) =>
            {
                FigureList.Add(args.Figure);
            };

            newInputForm.Show();
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if (FigureDataGridView.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in FigureDataGridView.SelectedRows)
                {
                    FigureList.Remove(row.DataBoundItem as FigureBase);
                }
            }
            else
            {
                MessageBox.Show("No selected items");
            }
        }
    }
}
