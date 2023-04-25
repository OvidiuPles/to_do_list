public class Task
{
    readonly string name;
    readonly string description;
    readonly string location;
    readonly string deadline;
    public Task(string name, string description, string location, string deadline)
    {
        this.name = name;
        this.description = description;
        this.location = location;
        this.deadline = deadline;
    }

    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public string Location { get { return location; } }
    public string Deadline { get { return deadline; } }
}