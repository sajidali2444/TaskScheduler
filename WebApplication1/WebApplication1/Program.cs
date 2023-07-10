using WebApplication1;
using TaskScheduler = WebApplication1.TaskScheduler;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var scheduler = new TaskScheduler();
scheduler.Register(new CustomTasks(1, DateTime.Now.AddSeconds(2)));
scheduler.Register(new CustomTasks(2, DateTime.Now.AddSeconds(2)));
scheduler.Register(new CustomTasks(3, DateTime.Now.AddSeconds(2)));
scheduler.Register(new CustomTasks(4, DateTime.Now.AddSeconds(2)));
scheduler.Register(new CustomTasks(5, DateTime.Now.AddSeconds(2)));
scheduler.AddDependencies("Task1","Task2");
var executedTask = await scheduler.ExecuteTasks();
foreach (var taskId in executedTask)
{
    Console.WriteLine($"Task completed: {taskId}");
}

app.MapGet("/", () => "Hello World!");

app.Run();