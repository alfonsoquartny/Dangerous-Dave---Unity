using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCode : MonoBehaviour
{

    public Animator kameraAnimator;
    public bool degisken;
    public Transform spawnPoint;
    public DenemeMovement MovementCode;
    public int hearts=3;
    public bool isDead;
    public float timer = 0;
    public int gecis3=1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gecis3 == 3)
        {
            kameraAnimator.SetInteger("gecisInt", 3);
        }
        if (isDead == true)
        {
            timer += Time.deltaTime;
        }
        if (timer > 2)
        {
            isDead = false;
            MovementCode.speedeger = 3f;
            MovementCode.jumpdeger = 9f;

        }
        if (isDead == false)
        {
            timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.gameObject.CompareTag("gecis"))
        {
            kameraAnimator.SetInteger("gecisInt", 1);
            gecis3 = 0;
        }
        if (collision.gameObject.CompareTag("gecis2"))
        {
            gecis3 = 3;
        }
        if (collision.gameObject.CompareTag("fire"))
        {
            MovementCode.speedeger = 0f;
            MovementCode.jumpdeger = 0f;
            gameObject.transform.position = spawnPoint.transform.position;
            hearts = hearts - 1;
            isDead = true;
          
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gecis")&&gecis3==0)
        {
            kameraAnimator.SetInteger("gecisInt", 2);
        }

        if (collision.gameObject.CompareTag("gecis2"))
        {
            gecis3 = 0;
        }
    }

}
