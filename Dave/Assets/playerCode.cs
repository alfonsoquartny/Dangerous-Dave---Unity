using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCode : MonoBehaviour
{
    public int hearts;

    public Animator kameraAnimator;
    public bool degisken;
    public GameObject spawnPoint;
    public DenemeMovement MovementCode;
    public int gecis3=1;

    public GameObject lives3;
    public GameObject lives2;
    public GameObject lives1;

    public GameObject bosluk;
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        
     
        spawnPoint = GameObject.FindGameObjectWithTag("spawnpoint");
        gameObject.transform.position = spawnPoint.transform.position;
        lives3 = GameObject.FindGameObjectWithTag("lives3");
        lives2 = GameObject.FindGameObjectWithTag("lives2");
        lives1 = GameObject.FindGameObjectWithTag("lives1");
    }

    // Update is called once per frame
    void Update()
    {

        DontDestroyOnLoad(gameObject);
        lives2 = GameObject.FindGameObjectWithTag("lives2");
        lives1 = GameObject.FindGameObjectWithTag("lives1");
        lives3 = GameObject.FindGameObjectWithTag("lives3");
        bosluk = GameObject.FindGameObjectWithTag("bosluk");



        if (hearts < 3)
        {
            lives3.transform.position = bosluk.transform.position;  
        }
        if (hearts < 2)
        {
            lives2.transform.position = bosluk.transform.position;
        }
        if (hearts < 1)
        {
            lives1.transform.position = bosluk.transform.position;
        }

    

        if (gecis3 == 3)
        {
            kameraAnimator.SetInteger("gecisInt", 3);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            gameObject.transform.position = spawnPoint.transform.position;
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
            gameObject.transform.position = spawnPoint.transform.position;
            hearts  = hearts - 1;
       
          
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
