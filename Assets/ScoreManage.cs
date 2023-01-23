using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    public static ScoreManage instance;
    //
   
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

    // Update is called once per frame
    //public void ChangeScore(int appleValue)
    //{
        //score += appleValue;
        //txt.text = "X" + score.ToString();
        //PlayerPrefs.SetString("CurrentScore", txt.text);
        //Debug.Log(PlayerPrefs.GetString("CurrentScore"));
        
    //}


}
