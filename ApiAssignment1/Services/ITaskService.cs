using ApiAssignment1.Models;

namespace ApiAssignment1.Services
{
    public interface ITaskService
    {
        List<TaskModel> GetAll();
        TaskModel? GetOne(int index);
        TaskModel Create(TaskModel model);
        TaskModel? Update(int index, TaskModel model);
        TaskModel? Delete(int index);
    }
}