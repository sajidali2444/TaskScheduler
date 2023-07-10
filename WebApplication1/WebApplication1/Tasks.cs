namespace WebApplication1;


public class CustomTasks
{
    public CustomTasks(int taskId, DateTime executionTime)
    {
        TaskId = taskId;
        ExecutionTime = executionTime;
        
    }
    public int TaskId { get; set; }
    public DateTime ExecutionTime { get; set; }
    //public Dictionary<string,string> Depndency { get; set; }
    //public List<Tasks> TaskDep { get; set; }
}
