using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeneralCode : MonoBehaviour
{
    public skorsistem Code;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Code.scor = Code.scor + 500;
            
        }
    }
}
