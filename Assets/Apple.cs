using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Apple : MonoBehaviour
{
    public static int totalScore;
    



    private void Update()
    {
        if (Score.applepickedUp == true)
        {
            gameObject.SetActive(false);
        }
       
    }

}

