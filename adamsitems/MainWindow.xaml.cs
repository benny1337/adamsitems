using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace adamsitems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskRepository _repo;

        public MainWindow()
        {
            InitializeComponent();
            _repo = new TaskRepository();
            this.DataContext = _repo.Tasks;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var task = new Task()
            {
                Name = "ett gott exempel",
                Prio = TaskType.viktigsomfan
            };
            _repo.AddTask(task);            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var task = this.dataGrid.SelectedItem as Task;
            _repo.RemoveTask(task);
        }
    }
}
