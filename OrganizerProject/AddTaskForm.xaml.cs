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
using System.Windows.Shapes;

namespace OrganizerProject
{
    /// <summary>
    /// Interaction logic for AddTaskForm.xaml
    /// </summary>
    public partial class AddTaskForm : Window
    {
        // creating an instance of Service class
        Service.Service service = new Service.Service();

        public AddTaskForm()
        {
            InitializeComponent();
        }

        // overload constructor
        public AddTaskForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            dpStart.DisplayDate = startDate;
            dpStart.SelectedDate = startDate;
            dpEnd.DisplayDate = endDate;
            dpEnd.SelectedDate = endDate;
        }

        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task()
            {
                Title = txtTitle.Text,
                Start = (DateTime)dpStart.SelectedDate,
                Finish = dpEnd.SelectedDate,
                Description = txtDescription.Text,
                Location = txtLocation.Text,
                IsFinished = false
            };

            if (service.AddTask(task))
            {
                DateTime? dateSelected = (DateTime?)dpStart.SelectedDate;

                MainWindow main = new MainWindow(dateSelected);
                this.Close();
                main.Show();
            }
        }
    }
}
