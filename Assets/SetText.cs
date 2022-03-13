using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{

    private Text symbol;
    // Start is called before the first frame update
    void Start()
    {
        symbol = gameObject.GetComponentInChildren<Text>();
        if (gameObject.name.Equals("Divide"))
            symbol.text = "\u00f7";
        else symbol.text = "?";
    }
}
