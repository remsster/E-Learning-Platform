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
        output.text = category;
        courseManager.GetCourses(category);
    }
}
