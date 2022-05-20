
using UnityEngine;
using UnityEngine.UI;

public class CourseManager : MonoBehaviour
{
    

    
    [SerializeField] UnityEngine.UI.Button buttonPrefab;

    [SerializeField] GameObject content;
    
    // test data for the
    private Course[] courses = 
        { 
        new Course { name = "Basic Mathmetics",category = "Mathmetics", description = "The basics of mathematics"},
        new Course { name = "Enginering Mechanics",category = "Engineering", description = "Learn about mechanical engineering"},
        new Course { name = "Biology",category = "Science", description = "Learning about the human body"},
        new Course { name = "Algebra",category = "Mathmetics", description = "Learing about linear algebra"},
        new Course { name = "Chemistry",category = "Science", description = "Learning about chemical reactions"},
        new Course { name = "Astrology",category = "Science", description = "Learning about space"},
        new Course { name = "Tudors",category = "History", description = "Learning about henry VIII"},
        new Course { name = "Egyptians",category = "History", description = "Learning about "}
    };

    

    public void GetCourses(string category = "")
    {
        foreach(Transform child in content.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i].category.Equals(category) || category == "")
            {

                Button b = Instantiate(buttonPrefab, content.transform);
                b.GetComponentInChildren<Text>().text = courses[i].name;
            }
        }
        
        
    }
}
