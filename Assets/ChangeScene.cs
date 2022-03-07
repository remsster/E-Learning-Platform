using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // X Button
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            SceneManager.LoadScene("Simple Math Lab");
        }
        
        if (Input.GetButtonDown("XRI_Left_SecondaryButton")) Debug.Log("Y Button Pressed");
        if (Input.GetButtonDown("XRI_Left_MenuButton")) Debug.Log("Menu Button Pressed");
    }
}
