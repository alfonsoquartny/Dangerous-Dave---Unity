using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorsistem : MonoBehaviour
{
    public int scor = 0;
    public Text scorBoard;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scorBoard.text = "SCORE :  " + scor.ToString();
    }
}
