using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamsitems
{
    public class TaskRepository
    {
        private ObservableCollection<Task> _tasks;
        public TaskRepository()
        {
            _tasks = new ObservableCollection<Task>();
            AddTask(new Task()
            {
                Name = "detta är ett exempel"
            });
        }

        public ObservableCollection<Task> Tasks
        {
            get
            {
                return _tasks;
            }
        }

        public void AddTask(Task t)
        {
            _tasks.Add(t);
        }

        public void RemoveTask(Task t)
        {
            _tasks.Remove(t);
        }
    }
}
