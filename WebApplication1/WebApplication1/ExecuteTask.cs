

namespace WebApplication1;

public class TaskScheduler
{
    private List<CustomTasks> Tasks { get; }
    private Dictionary<string, string> Dependencies = new Dictionary<string, string>();


    public void Register(CustomTasks task)
    {
        Tasks.Add(task);
    }

    public void AddDependencies(string depName, string dep)
    {
        Dependencies.Add(depName, dep);
    }

    public async Task<List<int>> ExecuteTasks()
    {
        List<int> completedTask = new List<int>();
        foreach (var task in Tasks)
        {
            Thread.Sleep(task.ExecutionTime.Second);
            completedTask.Add(task.TaskId);
        }
        return completedTask;
    }
}