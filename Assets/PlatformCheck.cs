using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCheck : MonoBehaviour
{
    [SerializeField] private LayerMask Platform;

    public bool groundCheck;

    private void OnTriggerStay2D(Collider2D collider)
    {
        groundCheck = collider != null && (((1 << collider.gameObject.layer) & Platform) != 0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        groundCheck = false;
    }
}
