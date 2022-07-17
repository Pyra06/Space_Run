using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 15f;
    public float mapWidth = 4f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector3 newPostion = rb.position + Vector3.right * x;

        newPostion.x = Mathf.Clamp(newPostion.x, -mapWidth, mapWidth);

        rb.MovePosition(newPostion);
    }
}
