
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CourseManager : MonoBehaviour
{   
    [SerializeField] UnityEngine.UI.Button buttonPrefab;

    [SerializeField] GameObject content;

    [SerializeField] GameObject panelCourseTitle;
    [SerializeField] GameObject panelCourseDescription;

    private Dictionary<string,Course> courses = new Dictionary<string, Course>()
    {
        { "0001", new Course {Id ="0001", Name = "Basic Mathmetics",Category ="Mathmetics",Description ="The basics of mathematics"} },
        { "0002", new Course {Id = "0002", Name = "Enginering Mechanics", Category = "Engineering", Description = "Learn about mechanical engineering"}},
        { "0003", new Course {Id = "0003", Name = "Biology", Category = "Science", Description = "Learning about the human body"}},
        { "0004", new Course {Id = "0004", Name = "Algebra", Category = "Mathmetics", Description = "Learing about linear algebra"}},
        { "0005", new Course {Id = "0005", Name = "Chemistry", Category = "Science", Description = "Learning about chemical reactions"}},
        { "0006", new Course {Id = "0006", Name = "Astrology", Category = "Science", Description = "Learning about space"}},
        { "0007", new Course {Id = "0007", Name = "Tudors", Category = "History", Description = "Learning about henry VIII"}},
        { "0008", new Course {Id = "0008", Name = "Egyptians", Category = "History", Description = "Learning about "}},
    };

    
    


    
    // test data for the
    // private Course[] courses = 
    //     { 
        // new Course { name = "Basic Mathmetics",category = "Mathmetics", description = "The basics of mathematics"},
        // new Course { name = "Enginering Mechanics",category = "Engineering", description = "Learn about mechanical engineering"},
        // new Course { name = "Biology",category = "Science", description = "Learning about the human body"},
        // new Course { name = "Algebra",category = "Mathmetics", description = "Learing about linear algebra"},
        // new Course { name = "Chemistry",category = "Science", description = "Learning about chemical reactions"},
        // new Course { name = "Astrology",category = "Science", description = "Learning about space"},
        // new Course { name = "Tudors",category = "History", description = "Learning about henry VIII"},
        // new Course { name = "Egyptians",category = "History", description = "Learning about "}
    // };

    public void SetCourse(string courseId)
    {
        Course pickedCourse = courses[courseId];
        panelCourseTitle.GetComponent<Text>().text = pickedCourse.Name;
        panelCourseDescription.GetComponent<Text>().text = pickedCourse.Description;
    }

    public void GetCourses(string category = "")
    {
        foreach(Transform child in content.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach(KeyValuePair<string,Course> course in courses)
        {
            if (course.Value.Category.Equals(category) || category == "") 
            {
                Button b = Instantiate(buttonPrefab, content.transform);
                b.GetComponentInChildren<Text>().text = $"{course.Value.Id} : {course.Value.Name}";   
            }
        }
    }
}
