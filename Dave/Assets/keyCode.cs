using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCode : MonoBehaviour
{
    public GameObject doorBlock;
    void Start()
    {
        doorBlock.SetActive(true);
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
        }
    }
}
