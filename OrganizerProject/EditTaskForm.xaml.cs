using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for EditTaskForm.xaml
    /// </summary>
    public partial class EditTaskForm : Window
    {
        // creating an instance of Service class
        Service.Service service = new Service.Service();

        public EditTaskForm()
        {
            InitializeComponent();
        }

        public EditTaskForm(Task task)
        {
            InitializeComponent();

            cbFinish.IsChecked = task.IsFinished;
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            txtLocation.Text = task.Location;
            dpStart.SelectedDate = task.Start;
            dpEnd.SelectedDate = task.Finish;
            txtId.Text = task.Id.ToString();
        }

        private void btnEditTask_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            if (service.EditTask(id, this))
            {
                DateTime? dateSelected = (DateTime?)dpStart.SelectedDate;
                MainWindow main = new MainWindow(dateSelected);
                this.Close();
                main.Show();
            }
        }

        private void btnDeleteTask_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            service.DeleteTask(id);

            DateTime? dateSelected = (DateTime?)dpStart.SelectedDate;
            MainWindow main = new MainWindow(dateSelected);
            this.Close();
            main.Show();
        }
    }
}
