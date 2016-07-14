using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    [Header("Player object values")]
    public Ball ball;
    [Tooltip("Speed in units per second")]
    [Range(1, 144f)]
    public float speed = 100;
    [Range(1, 10f)]
    public float jumpPower = 5;

    private Vector3 jumpForce;
    private bool isGrounded;

    public void Start()
    {
        jumpForce = new Vector3(0, jumpPower, 0);
    }
    public void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        bool j = Input.GetButtonDown("Jump");

        ball.Move(new Vector3(h, 0, v));

        if(j)
        {
            ball.Jump(jumpForce);
            Debug.Log("pressed jump");
        }
    }
}
