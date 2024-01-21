using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for Classic.xaml
    /// </summary>
    public partial class Classic : Window
    {
        public Classic()
        {
            InitializeComponent();
            Fill_List();
        }

        public List<test> list { get; set; }

        private async void Fill_List()
        {
            list = new List<test>();

            var task = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    list.Add(new test(i.ToString(), (i % 5).ToString()));
                }
            });
            await task;


            MainGrid.ItemsSource = list;

            ICollectionView cvTasks = CollectionViewSource.GetDefaultView(MainGrid.ItemsSource);
            if (cvTasks != null && cvTasks.CanGroup == true)
            {
                cvTasks.GroupDescriptions.Clear();
                cvTasks.GroupDescriptions.Add(new PropertyGroupDescription(nameof(test.b)));
            }
        }
    }
}
