using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        float x;
        if (Random.Range(0, 2) == 1)
            x = 1;
        else
            x = -1;

        float y;
        if (Random.Range(0, 2) == 1)
            y = 1;
        else
            y = -1;
        rb.linearVelocity = new Vector2(speed * x, speed * y);
    }
}


