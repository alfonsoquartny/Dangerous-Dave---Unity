using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCode : MonoBehaviour
{
    public GameObject doorBlock;
    public GameObject finishText;
    void Start()
    {
        doorBlock.SetActive(true);
        finishText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            doorBlock.SetActive(false);
            gameObject.SetActive(false);
            finishText.SetActive(true);
        }
    }
}
