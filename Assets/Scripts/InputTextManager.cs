using UnityEngine;
using UnityEngine.UI;



public class InputTextManager : MonoBehaviour
{
    [SerializeField] Text inputFieldText;
    [SerializeField] Text output;
    [SerializeField] CourseManager courseManager; 

    private void Start() {
        courseManager.GetComponent<CourseManager>();
    }

    public void SetText() 
    {
        string category = inputFieldText.text;
        output.text = (category.Equals(""))? "All Courses" : category;

        // Text from the textfield gets passed to the course manager
        courseManager.GetCourses(category);
    }
}
