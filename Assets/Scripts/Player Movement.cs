using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;

    public Vector2 moveDirection;
    public Vector3 moveVector;
    InputSystem_Actions actions;


    InputAction move;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        moveDirection = move.ReadValue<Vector2>().normalized;
        moveVector = player.transform.forward * moveDirection.y + player.transform.right * moveDirection.x;

        rb.linearVelocity = moveVector * 3;
        
    }

    private void Awake()
    {
        actions = new InputSystem_Actions();
    }
    private void OnEnable()
    {
        move = actions.Player.Move;

        actions.Player.Enable();
    }
}
