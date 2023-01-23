using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class HealthController : MonoBehaviour
{
    public float PlayerHealth = 100;
    [SerializeField] private Text healthtext;

    public void Start()
    {
        UpdateHP();
    }

    public void UpdateHP()
    {
        healthtext.text = PlayerHealth.ToString("0");
        if(PlayerHealth <= 10)
        {
            SceneManager.LoadScene("MainMenu");   
        }
    }

    public void Update()
    {
        if (PlayerHealth > 100)
        {
            PlayerHealth = 100;
        }
         
    }
}
