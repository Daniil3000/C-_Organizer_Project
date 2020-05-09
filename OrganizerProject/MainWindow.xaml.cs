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

namespace OrganizerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service.Service service = new Service.Service();
        public MainWindow()
        {
            InitializeComponent();
        }

        // overload constructor
        public MainWindow(DateTime? date)
        {
            InitializeComponent();
            myCalendar.SelectedDate = date;
        }

        public bool BindData(DateTime? date)
        {
            // populate datagrid with query result
            if (service.GetTasks(date).Count > 0)
            {
                dgTasks.DataContext = service.GetTasks(date);
                return true;
            }
            return false;
            
        }

        private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            tbDate.Visibility = Visibility.Visible;
            btnCreateTask.Visibility = Visibility.Visible;
            DateTime? date = myCalendar.SelectedDate;
            if (BindData(date))
            {
                existingTasks.Visibility = Visibility.Visible;
            }
            else existingTasks.Visibility = Visibility.Hidden;
        }

        private void btnCreateTask_Click(object sender, RoutedEventArgs e)
        {
            DateTime startDate = (DateTime)myCalendar.SelectedDate;
            DateTime endtDate = (DateTime)myCalendar.SelectedDate;

            AddTaskForm taskForm = new AddTaskForm(startDate, endtDate);
            this.Close();
            taskForm.Show();
            
        }

        private void dgTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            object selectedItem = dgTasks.SelectedItem;
            string taskTitle = (dgTasks.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
            DateTime? date = myCalendar.SelectedDate;
            int id = service.GetId(date, taskTitle);

            Task task = service.GetTaskById(id);

            EditTaskForm editForm = new EditTaskForm(task);

            this.Close();
            editForm.Show();
        }
    }
}
