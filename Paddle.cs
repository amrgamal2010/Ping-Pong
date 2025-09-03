using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private float _movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            _movement = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            _movement = Input.GetAxisRaw("Vertical2");
        }

        rb.linearVelocity = new Vector2(0, _movement * speed);
    }
    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPosition;
    }
}
