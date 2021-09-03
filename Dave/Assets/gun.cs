using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public bool silahAlýndý = false;
    public float timer = 2;
    public bool isTimer;

    public GameObject bullet;

    public GameObject gunImage;

    public GameObject hedef;

    public float speed = 1f;
   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

#pragma checksum
     
        if (Input.GetKey(KeyCode.E))
        {
            bullet.transform.position = hedef.transform.position*speed;
        }
        gunImage = GameObject.FindGameObjectWithTag("gun");

        if (silahAlýndý == true && timer == 2 && Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("ATEÞ EDÝLDÝ");
            isTimer = true;
        }

        if (isTimer == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            isTimer = false;
            timer = 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gun"))
        {
            silahAlýndý = true;
            gunImage.SetActive(false);
        }
    }
}
