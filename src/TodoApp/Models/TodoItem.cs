namespace TodoApp.Models;

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool IdDone { get; set; } = false;
}    
