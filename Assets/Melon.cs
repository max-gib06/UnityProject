using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
    public static int MelonScore;
    // Start is called before the first frame update


    // Update is called once per frame
    public void Update()
    {
        if (Score.melonpickedUp == true)
        {
            gameObject.SetActive(false);
        }
    }
}
