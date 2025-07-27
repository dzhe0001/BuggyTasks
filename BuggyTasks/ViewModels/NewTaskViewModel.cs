using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using BuggyTasks.Services;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{
    [ObservableProperty]
    string newTaskTitle;

    public ICommand AddNewTaskCommand { get; } 

    public NewTaskViewModel()
    {
        AddNewTaskCommand = new RelayCommand(OnAddTask);
    }

    void OnAddTask()
    {
        if (!string.IsNullOrWhiteSpace(NewTaskTitle))
        {
            // Add task to shared service
            TaskService.Instance.AddTask(NewTaskTitle);
            
            // Clear the input field
            NewTaskTitle = string.Empty;
            
            Console.WriteLine($"Added task: {NewTaskTitle}");
        }
    }
}