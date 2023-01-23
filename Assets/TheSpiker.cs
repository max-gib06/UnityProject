using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSpiker : MonoBehaviour
{
    public Transform firepoint;
    public GameObject projectile;
    float timecooldown;
    public float starttime;
    // Start is called before the first frame update
    void Start()
    {
        timecooldown = starttime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timecooldown <= 0)
        {
            Instantiate(projectile, firepoint.position, firepoint.rotation);
            timecooldown = starttime;
        }
        else
        {
            timecooldown -= Time.deltaTime;
        }
    }
}
