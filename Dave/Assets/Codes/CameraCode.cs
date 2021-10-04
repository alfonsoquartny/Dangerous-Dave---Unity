using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraCode : MonoBehaviour
{

    public int activeLevel = 0;
    public GameObject spawnPointCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (activeLevel > 1)
        {
            gameObject.transform.position = spawnPointCamera.transform.position;
            activeLevel = 0;
        }
        
    }
}
    