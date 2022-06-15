using UnityEngine;
using UnityEngine.UI;

public class CourseButtonSetter : MonoBehaviour
{
    CourseManager courseManager;

    private void Awake() {
        courseManager = FindObjectOfType<CourseManager>();
    }

    // Called by course button
    public void ButtonClicked()
    {
        string id = gameObject.GetComponentInChildren<Text>().text.Substring(0,4);
        courseManager.SetCourse(id);
    }    

    // Called by enroled course button
    public void ButtonEnroledClicked()
    {
        string id = gameObject.GetComponentInChildren<Text>().text.Substring(0, 4);
        courseManager.SetEnrolledCourse(id);
    }
}
