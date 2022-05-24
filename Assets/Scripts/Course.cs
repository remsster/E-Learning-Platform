
[System.Serializable]
public class Course
{
    private string id;
    private string name;
    private string category;
    private string description;

    public string Id { get; set;}
    public string Name { get; set;}
    public string Category { get; set;}
    public string Description { get; set;}

    public Course() { }

    public Course(string id, string name, string category, string description)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.description = description;
    }
}
