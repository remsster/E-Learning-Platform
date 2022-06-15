
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CourseManager : MonoBehaviour
{
    // prefaps to instanciate
    [Header("Button Prefabs")]
    [SerializeField] UnityEngine.UI.Button buttonPrefab;
    [SerializeField] UnityEngine.UI.Button enrolButtonPrefab;


    
    

    [Header("Main panel objects")]
    [SerializeField] GameObject panelCourseTitle;
    [SerializeField] GameObject panelCourseDescription;
    [SerializeField] GameObject playAudioButton;
    [SerializeField] GameObject mainCourseView;
    [SerializeField] GameObject coursesScrollViewContent;

    [Header("Enrol panel objects")]
    [SerializeField] GameObject panelEnrolledTitle;
    [SerializeField] GameObject enrolCourseDetailView;
    [SerializeField] GameObject enroledCoursesScrollViewContent;

    // refrence for moving courses between dictionaries
    private Course currentlySelectedCourse;

    private Dictionary<string,Course> courses = new Dictionary<string, Course>()
    {
        { 
            "0001", new Course {
                Id = "0001", Name = "Intro To Mathematics",Category ="Mathematics",
                Description ="Mathematical thinking is not the same as doing mathematics – at least not as mathematics is typically presented in our school system. School math typically focuses on learning procedures to solve highly stereotyped problems. Professional mathematicians think a certain way to solve real problems, problems that can arise from the everyday world, or from science, or from within mathematics itself. The key to success in school math is to learn to think inside-the-box. In contrast, a key feature of mathematical thinking is thinking outside-the-box – a valuable ability in today’s world. This course helps to develop that crucial way of thinking."
            } 
        },
        {
            "0002", new Course {
                Id = "0002", Name = "Mathematics For Engineers",Category ="Mathematics",
                Description ="Learn the Mathematics needed to become an Engineer. Study matrix algebra, differential equations, vector calculus, numerical methods and complete a capstone project."
            }
        },
        {
            "0003", new Course {
                Id = "0003", Name = "Mathematics For Machine Learning",Category ="Mathematics",
                Description ="Mathematics for Machine Learning. Learn about the prerequisite mathematics for applications in data science and machine learning."
            }
        },
        {
            "0004", new Course {
                Id = "0004", Name = "Basic English",Category ="Languages",
                Description ="Improve Your English Communication Skills."
            }
        },
        {
            "0005", new Course {
                Id = "0005", Name = "Advance Chinese",Category ="Languages",
                Description ="Improve Your Chinese Communication Skills."
            }
        },
        {
            "0006", new Course {
                Id = "0006", Name = "3D Graphics Design",Category ="Arts",
                Description ="Learn to design in a 3D space."
            }
        },
        {
            "0007", new Course {
                Id = "0007", Name = "Basic Anatomy",Category ="Health",
                Description ="In this Specialization you will explore human anatomy using a systems approach, and a vast library of multimedia materials, so you may understand the features of different organ systems in relation to the human body’s form and function."
            }
        },
        {
            "0008", new Course {
                Id = "0008", Name = "Nurobiology - Understanding the Brain",Category ="Health",
                Description ="Learn how the nervous system produces behavior, how we use our brain every day, and how neuroscience can explain the common problems afflicting people today. We will study functional human neuroanatomy and neuronal communication, and then use this information to understand how we perceive the outside world, move our bodies voluntarily, stay alive, and play well with others."
            }
        },

    };

    private Dictionary<string, Course> enrolledCourses = new Dictionary<string, Course>();

    private void Start()
    {
        mainCourseView.SetActive(false);
        enrolCourseDetailView.SetActive(false);
    }

    /// <summary>
    /// Show course details in the main course panel
    /// </summary> 
    /// <param name="courseId">the course id</param>
    public void SetCourse(string courseId)
    {
        if (mainCourseView.activeSelf == false) mainCourseView.SetActive(true);
        Course pickedCourse = courses[courseId];
        currentlySelectedCourse = pickedCourse;
        panelCourseTitle.GetComponent<Text>().text = pickedCourse.Name;
        panelCourseDescription.GetComponent<Text>().text = pickedCourse.Description;
        playAudioButton.GetComponent<PlayAudio>().SetAudioClip(courseId);
    }

    /// <summary>
    /// Set details for the enroled course in the enroled panel
    /// </summary>
    /// <param name="id">the course id</param>
    public void SetEnrolledCourse(string id)
    {
        if (enrolCourseDetailView.activeSelf == false) enrolCourseDetailView.SetActive(true);
        Course enroledPickedCourse = enrolledCourses[id];
        currentlySelectedCourse = enroledPickedCourse;
        panelEnrolledTitle.GetComponent<Text>().text = enroledPickedCourse.Name;

    }

    
    // Called by enrol button in engine
    public void EnrolOnCourse()
    {
        mainCourseView.SetActive(false);
        if (currentlySelectedCourse == null || currentlySelectedCourse.Equals("")) return;
        courses.Remove(currentlySelectedCourse.Id);
        enrolledCourses.Add(currentlySelectedCourse.Id, currentlySelectedCourse);
        DisplayEnroledCourses();
    }

    public void RemoveEnroledCourse()
    {
        enrolCourseDetailView.SetActive(false);
        if (currentlySelectedCourse == null || currentlySelectedCourse.Equals("")) return;
        enrolledCourses.Remove(currentlySelectedCourse.Id);
        courses.Add(currentlySelectedCourse.Id, currentlySelectedCourse);
        DisplayEnroledCourses();
    }

    /// <summary>
    /// Displays enroled courses in horizontal scroll view
    /// </summary>
    public void DisplayEnroledCourses()
    {
        DisplayCourses();
        foreach (Transform child in enroledCoursesScrollViewContent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach (KeyValuePair<string, Course> course in enrolledCourses)
        {
            Button b = Instantiate(enrolButtonPrefab, enroledCoursesScrollViewContent.transform);
            b.GetComponentInChildren<Text>().text = $"{course.Value.Id} : {course.Value.Name}";   
        }

    }

    /// <summary>
    /// Displays courses in vertical scroll view in main course panel
    /// </summary>
    /// <param name="category">Able to filter courses by category form keyboard input</param>
    public void DisplayCourses(string category = "")
    {
        foreach(Transform child in coursesScrollViewContent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        foreach(KeyValuePair<string,Course> course in courses)
        {
            if (course.Value.Category.ToLower().Equals(category) || category == "") 
            {
                Button b = Instantiate(buttonPrefab, coursesScrollViewContent.transform);
                b.GetComponentInChildren<Text>().text = $"{course.Value.Id} : {course.Value.Name}";   
            }
        }
    }
}
