using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Weapon weapon;
    private float _velocity;
    private float _jumpForce=5;
    private float _runVelocity;
    private Rigidbody _rb;
    private bool _inGround=true;

    void Start()
    {
        Rigid();
    }
    void Update()
    {
        Jump();
        shoot();
    }
    void FixedUpdate()
    {
        Movement();
    }
    public void Movement()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 MoveF = new Vector3(MoveX, 0, MoveZ);

        _rb.MovePosition(_rb.position + MoveF * _velocity * Time.fixedDeltaTime);
    }
    public void Rigid()
    {
        _rb = GetComponent<Rigidbody>();
        
    }
    public void Run()
    {

    }
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&_inGround)
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _inGround = false;
        }
    }
    public void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weapon?.Attack();
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _inGround = true;
        }
    }
}
