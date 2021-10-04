using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteRendererChance : MonoBehaviour
{
    public Sprite agac;
    public Sprite tablo;
    public Sprite lamba;
    public SpriteRenderer spriteRenderer;


    public bool agacTemas;
    public bool tabloTemas;
    public bool lambaTemas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&tabloTemas==true)
        {
            spriteRenderer.sprite = tablo;
            
        }
        if (Input.GetKeyDown(KeyCode.Space) &&agacTemas==true)
        {
            spriteRenderer.sprite = agac;
        }

        if (Input.GetKeyDown(KeyCode.Space) && lambaTemas == true)
        {
            spriteRenderer.sprite = lamba;
        }
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("agac"))
        {
            agacTemas = true;
        }
        if (collision.gameObject.CompareTag("lamba"))
        {
          lambaTemas = true;
        }
        if (collision.gameObject.CompareTag("Tablo"))
        {
            tabloTemas = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("lamba"))
        {
           lambaTemas = false;
        }
        if (collision.gameObject.CompareTag("agac"))
        {
           agacTemas = false;
        }
        if (collision.gameObject.CompareTag("Tablo"))
        {
            tabloTemas =false;
        }
    }
}
