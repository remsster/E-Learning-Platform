using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float yBound = -10f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yBound) Destroy(gameObject);
    }
}
