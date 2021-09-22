using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class degiskenler : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void levelAtla()
     {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     }
}
