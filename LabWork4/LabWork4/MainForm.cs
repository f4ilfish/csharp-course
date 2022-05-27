using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Model;
using System.Xml.Serialization;

namespace View
{
    /// <summary>
    /// Class main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Figures list field's property
        /// </summary>
        private BindingList<FigureBase> _figureList = new();

        private readonly Dictionary<string, Type> _figureTypes = new ()
        {
            {nameof(Sphere), typeof(Sphere)},
            {nameof(Pyramid), typeof(Pyramid)},
            {nameof(Parallelepiped), typeof(Parallelepiped)}
        };

        /// <summary>
        /// Main form instance constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            FigureDataGridView.DataSource = _figureList;

            FigureTypeCheckedListBox.DataSource = _figureTypes.Keys.ToList();

            FromTextBox.KeyPress += CheckKeyPress;
            ToTextBox.KeyPress += CheckKeyPress;

            FromTextBox.Validated += SetZeroToTextBoxes;
            ToTextBox.Validated += SetZeroToTextBoxes;
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

                FigureDataGridView.DataSource = _figureList;
            };

            newInputForm.Closed += (_, _) =>
            {
                AddFigureButton.Enabled = true;
            };

            AddFigureButton.Enabled = false;
        }
        
        /// <summary>
        /// Event RemoveFigureButton click
        /// </summary>
        /// <param name="sender">RemoveFigureButton</param>
        /// <param name="e">Event argument</param>
        private void RemoveFigureButton_Click(object sender, 
                                              EventArgs e)
        {
            if (FigureDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewCell cell in 
                         FigureDataGridView.SelectedCells)
                {
                    _figureList.Remove(cell.OwningRow.DataBoundItem 
                        as FigureBase);
                }
            }
            else
            {
                MessageBox.Show(@"No selected items");
            }
        }

        /// <summary>
        /// Event LoadToolStripMenuItem click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, 
                                                 EventArgs e)
        {
            var fileBrowser = new OpenFileDialog
            {
                Filter = "FiguresVolume (*.fvlm)|*.fvlm"
            };

            fileBrowser.ShowDialog();

            var path = fileBrowser.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<FigureBase>));

            try
            {
                using (var fileReader = new FileStream(path, 
                                                       FileMode.Open))
                {
                    _figureList = (BindingList<FigureBase>) 
                        xmlSerializer.Deserialize(fileReader);
                };

                FigureDataGridView.DataSource = _figureList;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(@"File upload error");
            }
            catch (ArgumentException)
            {
                MessageBox.Show(@"The data structure 
                                      of the uploaded file is broken");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            RefreshTextBoxes();
        }

        /// <summary>
        /// Event SaveToolStripMenuItem Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog
            {
                Filter = "FiguresVolume (*.fvlm)|*.fvlm"
            };

            fileBrowser.ShowDialog();

            var path = fileBrowser.FileName;

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<FigureBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using var fileWriter = new FileStream(path, FileMode.Create);
            
            xmlSerializer.Serialize(fileWriter, FigureDataGridView.DataSource);
        }

        /// <summary>
        /// Event FilterButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var typeFilteredList = new BindingList<FigureBase>();

            foreach (var figure in _figureList)
            {
                foreach (var checkedFigure in 
                         FigureTypeCheckedListBox.CheckedItems)
                {
                    if (figure.GetType() == _figureTypes[checkedFigure.
                                                            ToString()])
                    {
                        typeFilteredList.Add(figure);
                    }
                }
            }

            var valueFilteredList = new BindingList<FigureBase>();

            foreach (var figure in typeFilteredList)
            {
                if (figure.Volume >= Convert.ToDouble(FromTextBox.Text) &&
                    figure.Volume <= Convert.ToDouble(ToTextBox.Text))
                {
                    valueFilteredList.Add(figure);
                }
            }

            FigureDataGridView.DataSource = valueFilteredList;
        }

        /// <summary>
        /// Event ResetButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            FigureDataGridView.DataSource = _figureList;

            RefreshTextBoxes();
        }

        /// <summary>
        /// Check pressed key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckKeyPress(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            var eKey = (KeyPressEventArgs)e;

            if (char.IsNumber(eKey.KeyChar) ||
                (!string.IsNullOrEmpty(textBox.Text) && eKey.KeyChar == ',')
                || char.IsControl(eKey.KeyChar))
            {
                return;
            }

            eKey.Handled = true;
        }

        /// <summary>
        /// SetZeroToTextBoxes method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetZeroToTextBoxes(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        /// <summary>
        /// RefreshTextBox method
        /// </summary>
        private void RefreshTextBoxes()
        {
            if (_figureList.Count == 0) return;
            
            FromTextBox.Text = _figureList.Min(figure =>
                Math.Round(figure.Volume, 3)).
                ToString(CultureInfo.CurrentCulture); ;

            ToTextBox.Text = _figureList.Max(figure =>
                Math.Round(figure.Volume, 3)).
                ToString(CultureInfo.CurrentCulture);
        }
    }
}
