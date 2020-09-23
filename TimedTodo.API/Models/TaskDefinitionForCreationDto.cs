namespace TimedTodo.API.Models
{
  public class TaskDefinitionForCreationDto
  {
    public string Title { get; set; }
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
  }
}
