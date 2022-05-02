
using UnityEngine;
using UnityEngine.UI;

public class CourseManager : MonoBehaviour
{
    // string name;


    public UnityEngine.UI.Button buttonPrefab;

    public GameObject content;
    private Course[] courses = 
        { 
        new Course { name = "Basic Mathmetics",category = "Mathmetics", description = "The basics of mathematics"},
        new Course { name = "Enginering Mechanics",category = "Engineering", description = "Learn about mechanical engineering"},
        new Course { name = "Biology",category = "Science", description = "Learning about the human body"},
        new Course { name = "Algebra",category = "Mathmetics", description = "Learing about linear algebra"},
        new Course { name = "Chemistry",category = "Science", description = "Learning about chemical reactions"},
    };
    

    private void Start()
    {
        SetCourseArray();
        GetCourses();
    }


    public void SetCourseArray() {
        //courses = APIHelper.GetCourse();   
    }

    public void GetCourses()
    {

        //Debug.Log("Num of courses: " + courses.Length);
        for (int i = 0; i < courses.Length; i++)
        {
            Button b = Instantiate(buttonPrefab, content.transform);
            b.GetComponentInChildren<Text>().text = courses[i].name;
        }
        Debug.Log("I should see my courses");
        
    }
}
