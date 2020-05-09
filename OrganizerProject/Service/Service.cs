using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OrganizerProject.Service
{
    class Service
    {
        public bool AddTask(Task task)
        {
            using(var organizerContext = new OrganizerDBEntities())
            {
                // chech if task with the same title exists for this date
                var query = from tsk in organizerContext.Tasks
                            where tsk.Title == task.Title && tsk.Start == task.Start
                            select tsk;
                if(query.Count() > 0)
                {
                    // Configure the message box to be displayed
                    string messageBoxText = "Task with the same title is already created for this day!\n" +
                        "Do you want to create a task with a different title?";
                    string caption = "Task already exists";
                    MessageBoxButton button = MessageBoxButton.YesNo;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    // Display message box
                    MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                    if (result == MessageBoxResult.Yes)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    
                }
                else
                {
                    organizerContext.Tasks.Add(task);
                    organizerContext.SaveChanges();
                    MessageBox.Show("Task has been added!");
                    return true;
                }
                
            }
        }

        public List<Task> GetTasks(DateTime? date)
        {
            using(var organizerContext = new OrganizerDBEntities())
            {
                var query = from task in organizerContext.Tasks
                            where task.Start == date
                            select task;

                return query.ToList();
            }
        }

        public int GetId(DateTime? date, string taskTitle)
        {
            using(var organizerContext = new OrganizerDBEntities())
            {
                var query = from task in organizerContext.Tasks
                            where task.Start == date && task.Title == taskTitle
                            select task.Id;

                return Int32.Parse(query.First().ToString());
            }
        }

        public Task GetTaskById(int id)
        {
            using (var organizerContext = new OrganizerDBEntities())
            {
                var query = from task in organizerContext.Tasks
                            where task.Id == id
                            select task;

                return query.First();
            }
        }

        public bool EditTask(int id, EditTaskForm form)
        {
            using(var organizerContext = new OrganizerDBEntities())
            {
                // fetching a task we will edit
                var query = from task in organizerContext.Tasks
                            where task.Id == id
                            select task;
                Task taskToEdit = query.First();

                // assigning new values for the task
                taskToEdit.IsFinished = form.cbFinish.IsChecked;
                taskToEdit.Title = form.txtTitle.Text;
                taskToEdit.Description = form.txtDescription.Text;
                taskToEdit.Location = form.txtLocation.Text;
                taskToEdit.Start = (DateTime)form.dpStart.SelectedDate;
                taskToEdit.Finish = (DateTime)form.dpEnd.DisplayDate;

                // chech if task with the same title exists for this date
                var queryCheck = from tsk in organizerContext.Tasks
                            where tsk.Title == taskToEdit.Title && tsk.Start == taskToEdit.Start && tsk.Id != taskToEdit.Id
                            select tsk;
                if(queryCheck.Count() > 0)
                {
                    // Configure the message box to be displayed
                    string messageBoxText = "Task with the same title is already created for this day!\n" +
                        "Do you want to create a task with a different title?";
                    string caption = "Task already exists";
                    MessageBoxButton button = MessageBoxButton.YesNo;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    // Display message box
                    MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                    if (result == MessageBoxResult.Yes)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    // saving changes
                    organizerContext.SaveChanges();
                    return true;
                }
                
            }
            
        }

        public void DeleteTask(int id)
        {
            using (var organizerContext = new OrganizerDBEntities())
            {
                // fetching a task we will delete
                var query = from task in organizerContext.Tasks
                            where task.Id == id
                            select task;
                Task taskToDelete = query.First();

                organizerContext.Tasks.Remove(taskToDelete);
                organizerContext.SaveChanges();
            }
        }
    }
}
