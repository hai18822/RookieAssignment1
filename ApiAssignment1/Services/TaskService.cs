using ApiAssignment1.Models;

namespace ApiAssignment1.Services
{
    public class TaskService : ITaskService
    {
        private static List<TaskModel> _task = new List<TaskModel>{
            new TaskModel{
                Id = 1,
                Title = "Task 1",
                IsCompleted = true
            },
            new TaskModel{
                Id = 2,
                Title = "Task 2",
                IsCompleted = true
            },
            new TaskModel{
                Id = 3,
                Title = "Task 3",
                IsCompleted = true
            },
        };
        public TaskModel Create(TaskModel model)
        {
            _task.Add(model);
            return model;
        }

        public TaskModel? Delete(int index)
        {
            if (index >= 0 && index < _task.Count)
            {
                var person = _task[index];
                _task.RemoveAt(index);
                return person;
            }

            return null;
        }

        public List<TaskModel> GetAll()
        {
            return _task;
        }

        public TaskModel? GetOne(int index)
        {
            if (index >= 0 && index < _task.Count)
            {
                return _task[index];
            }

            return null;
        }

        public TaskModel? Update(int index, TaskModel model)
        {
            if (index >= 0 && index < _task.Count)
            {
                _task[index] = model;
                return model;
            }

            return null;
        }
    }
}