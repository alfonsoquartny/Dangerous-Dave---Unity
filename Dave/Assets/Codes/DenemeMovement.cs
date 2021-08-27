using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenemeMovement : MonoBehaviour
{

    Rigidbody2D rigi;
    Vector3 velocity;
    public Animator animator;

    public float speedeger = 10f;
    public float jumpdeger = 10f;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("isWalk", true);
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("isWalk", false);
        }
       
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedeger * Time.deltaTime;
        animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rigi.velocity.y, 0))
        {
            rigi.AddForce(Vector3.up * jumpdeger, ForceMode2D.Impulse);
            animator.SetBool("jumpp", true);
        }
        if (animator.GetBool("jumpp") && Mathf.Approximately(rigi.velocity.y, 0))
        {
            animator.SetBool("jumpp", false);
        }
        

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            animator.SetBool("jumpp", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            animator.SetBool("jumpp", true);
        }
    }
}
