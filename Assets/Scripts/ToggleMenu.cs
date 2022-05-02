using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    private Canvas canvas;
    private GameObject canvasGameObject;

    private void Awake()
    {
        
        canvasGameObject = GameObject.Find("Menu Canvas");
        canvas = canvasGameObject.GetComponent<Canvas>();
    }

    private void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Hands(Clone)"))
        {
            if (canvas.isActiveAndEnabled)
            { 
                canvas.gameObject.SetActive(false);
            }
            else
            {
                canvas.gameObject.SetActive(true);
                
            }
            

        }
    }
}
