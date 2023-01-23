using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    [SerializeField] private float HostileDamage;
    [SerializeField] public HealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
            FindObjectOfType<SoundManager>().Play("Fire");
        }
    }

    void Damage()
    {
        healthController.PlayerHealth = healthController.PlayerHealth - HostileDamage;
        healthController.UpdateHP();
        this.gameObject.SetActive(false); 
    }
}
