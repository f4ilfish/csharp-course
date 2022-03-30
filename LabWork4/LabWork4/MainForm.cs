using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        private List<FigureBase> _figureList = new();

        public List<FigureBase> FigureList
        {
            get => _figureList;
            set => _figureList = value;
        }

        public MainForm()
        {
            InitializeComponent();
            FigureDataGridView.DataSource = FigureList;
        }

        private void AddFigureButton_Click(object sender, System.EventArgs e)
        {
            InputForm newInputForm = new InputForm();

            newInputForm.Show();
        }
    }
}
