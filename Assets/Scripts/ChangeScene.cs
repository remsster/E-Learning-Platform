using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // X Button
        //if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        //{
        //    SceneManager.LoadScene("Simple Math Lab");
        //}
        
        //if (Input.GetButtonDown("XRI_Left_SecondaryButton")) Debug.Log("Y Button Pressed");
        //if (Input.GetButtonDown("XRI_Left_MenuButton")) Debug.Log("Menu Button Pressed");
    }

    public void MoveToMathLab()
    {
        SceneManager.LoadScene("Simple Math Lab");
    }

    public void MoveToHome()
    {
        SceneManager.LoadScene("Home");

    }


}
