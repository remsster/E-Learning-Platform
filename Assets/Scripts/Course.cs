
[System.Serializable]
public class Course
{
    public string name;
    public string category;
    public string description;

    public Course() { }

    public Course(string name, string category, string description)
    {
        this.name = name;
        this.category = category;
        this.description = description;
    }
}
