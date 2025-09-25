using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity=5;
    public Rigidbody rb;

    void Start()
    {
        Rigid();
    }
    void FixedUpdate()
    {
        Movemet();
    }
    public void Movemet()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 MoveF = new Vector3(MoveX, 0, MoveZ);

        rb.MovePosition(rb.position + MoveF * velocity * Time.deltaTime);
    }
    void Rigid()
    {
        rb = GetComponent<Rigidbody>();

    }
}
