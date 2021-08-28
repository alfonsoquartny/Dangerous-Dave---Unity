using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCode : MonoBehaviour
{

    public Animator kameraAnimator;
    public bool degisken;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gecis"))
        {
            kameraAnimator.SetInteger("gecisInt", 2);
        }
    }

}
