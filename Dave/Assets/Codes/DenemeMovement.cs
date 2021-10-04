using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenemeMovement : MonoBehaviour
{

    Rigidbody2D rigi;
    Vector3 velocity;
    public Animator animator;
    public float speedeger = 3f;
    public float jumpdeger = 9f;
    public bool isMove;
    void Start()
    {
        speedeger = 3f;
        jumpdeger=9f;
        rigi = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
      
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            isMove = false;
        }
        if (isMove == true)
        {
            animator.SetBool("isWalk", true);
        }
        if (isMove==false)
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
            isMove = true;
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            isMove = true;
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
