using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //private int score = 0;
    public Text AppleT;
    public Text BananaT;
    public Text MelonT;
    public static bool applepickedUp = false;
    public static bool bananapickedUp = false;
    public static bool melonpickedUp = false;
    public static bool SampleSceneunlock = true;

    private void Start()
    {
        AppleT.text = "x"+ Apple.totalScore;
        BananaT.text = "x" + Banana.BananaScore;
        MelonT.text = "x" + Melon.MelonScore;

    }
    // Start is called before the first frame update

    //public void AddPoints(int AppleValue)
    //{
    //score += AppleValue;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Apple")
        {
            applepickedUp = true;
            Apple.totalScore += 1;
            AppleT.text = "x" + Apple.totalScore;
           
        }
        if (collision.tag == "Banana")
        {
            bananapickedUp = true;
            Banana.BananaScore += 1;
            BananaT.text = "x" + Banana.BananaScore;

        }
        if (collision.tag == "Melon")
        {
            melonpickedUp = true;
            Melon.MelonScore += 1;
            MelonT.text = "x" + Melon.MelonScore;

        }
     
    }

}
