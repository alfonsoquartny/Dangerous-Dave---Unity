using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public GameObject monster;
    public bool isAlive;
    public float timer = 0;
    public Animator bulletAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (monster.activeInHierarchy == true)
        {
            isAlive = true;
            gameObject.SetActive(true);
        }

        if (isAlive == true)
        {
            timer += Time.deltaTime;
        }
        if (timer > 1.5)
        {
            gameObject.SetActive(true);
            bulletAnimator.SetBool("isFire", true);
        }
        if (timer > 3)
        {
            timer = -3;
        }
        if(timer> 2.999248)
        {
            gameObject.SetActive(false);
        }

        if (timer < 0)
        {
            bulletAnimator.SetBool("isFire", false);
        }
    }
}
