using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    // Start is called before the first frame update
    public static int BananaScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Score.bananapickedUp == true)
        {
            gameObject.SetActive(false);
        }
    }
}
