using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{

    public int intLeveltoLoad;
    public string stringLevelToLoad;
    public bool useIntegerToLoadLevel = false;
   
    //public TextMeshProUGUI Scoreholder;

    // Start is called before the first frame update
    void Start()
    {
        //Scoreholder.text = PlayerPrefs.GetString("CurrentScore");
      
        //PlayerPrefs.SetString("CurrentScore", Scoreholder.text);

         //Scoreholder.text = PlayerPrefs.GetString("CurrentScore");

        //PlayerPrefs.Save();
        

    }
       

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        if(collisionGameObject.name == "Player")
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        if (Score.SampleSceneunlock == true)
        {
            SceneManager.LoadScene(intLeveltoLoad);
        }

        if (Score.applepickedUp == true)
            {
                SceneManager.LoadScene(stringLevelToLoad);
            }
        if (Score.bananapickedUp == true)
        {
            SceneManager.LoadScene(stringLevelToLoad);
        }
        if (Score.melonpickedUp == true)
        {
            SceneManager.LoadScene(stringLevelToLoad);
        }

    }
    }

