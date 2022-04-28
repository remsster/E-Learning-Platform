using UnityEngine;
using UnityEngine.UI;

public class ChuckNorris : MonoBehaviour
{
    public Text jokeText;

    public void NewJoke()
    {
        Joke joke = APIHelper.GetNewJoke();
        jokeText.text = joke.value;
    }
}
