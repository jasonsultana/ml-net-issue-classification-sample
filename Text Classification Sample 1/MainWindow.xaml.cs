using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Text_Classification_Sample_1ML.Model;

namespace Text_Classification_Sample_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                dgResults.Items.Clear();

                var text = txtInput.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    var input = new ModelInput()
                    {
                        Content = text
                    };
                    var output = ConsumeModel.Predict(input);

                    foreach(var item in output)
                    {
                        dgResults.Items.Add(new DataGridResultColumn()
                        {
                            Label = item.Key,
                            Score = Math.Round(item.Value * 100, 2)
                        });
                    }
                }
            }
        }
    }
}
