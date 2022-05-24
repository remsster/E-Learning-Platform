using UnityEngine;
using UnityEngine.UI;

public class CourseButtonSetter : MonoBehaviour
{
    CourseManager courseManager;

    private void Awake() {
        courseManager = FindObjectOfType<CourseManager>();
    }

    public void ButtonClicked()
    {
        string id = gameObject.GetComponentInChildren<Text>().text.Substring(0,4);
        courseManager.SetCourse(id);
    }    
}
