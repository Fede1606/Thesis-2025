using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public float runSpeed=2;

    public float jumpSpeed = 3 ;

    public Animator animator;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {

        if ((Input.GetKey("d"))||(Input.GetKey("right")))
        {
            rb2D.linearVelocity = new Vector2(runSpeed, rb2D.linearVelocity.y);
        } 

        else if ((Input.GetKey("a"))||(Input.GetKey("left")))
        {
            rb2D.linearVelocity =new Vector2(-runSpeed, rb2D.linearVelocity.y); 
        }

        else
        {
            rb2D.linearVelocity =new Vector2(0,rb2D.linearVelocity.y);
        }

        animator.SetFloat("movement", runSpeed);


        if ((Input.GetKey("space") || Input.GetKey("up")) && CheckGround.isGrounded)
        {
            rb2D.linearVelocity =new Vector2(rb2D.linearVelocity.x, jumpSpeed); 
        }

    }


}
