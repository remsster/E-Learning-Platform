using UnityEngine;
using UnityEngine.InputSystem;

public class PersonController : MonoBehaviour
{
    [SerializeField] InputAction buttonAction;

    [SerializeField] GameObject coursePanel;

    // flag variable used for showing and hiding the menu
    private bool hide = true;

    private void OnEnable() {
        buttonAction.Enable();
    }

    private void OnDisable() {
        buttonAction.Disable();    
    }

    // Update is called once per frame
    void Update()
    {
        bool pressed = buttonAction.ReadValue<float>() > 0? true : false;
        
    }
}
