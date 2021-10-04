using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public bool silahAl�nd� = false;
    public float timer = 2;
    public bool isTimer;

    public GameObject bullet;

    public GameObject gunImage;

    public GameObject hedef;

    public float speed = 150f;

    public Rigidbody2D bulletRigid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

#pragma checksum
     
   
        gunImage = GameObject.FindGameObjectWithTag("gun");

        if (silahAl�nd� == true && timer == 2 && Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = 150f;
            bulletRigid.AddForce(transform.right * speed, ForceMode2D.Force);
            isTimer = true;
        }
        

        if (isTimer == true)
        {
            timer -= Time.deltaTime;
        }

        if (isTimer ==false)
        {
            bullet.transform.position = gameObject.transform.position;
        }


        if (timer < 0)
        {
            
            isTimer = false;
            timer = 2;
            speed = 0f;
            bullet.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gun"))
        {
            silahAl�nd� = true;
            gunImage.SetActive(false);
        }
    }
}
