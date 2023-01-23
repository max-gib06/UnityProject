/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform camerTransform;
    private Vector3 CheckCameraPosition;
    
    private void Start()
    {
        camerTransform = Camera.main.transform;
        CheckCameraPosition = camerTransform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 deltaMovement = camerTransform.position - CheckCameraPosition;
        float backgroundeffect = .5f;
        transform.position += deltaMovement * backgroundeffect;
        CheckCameraPosition = camerTransform.position;
    }
}
*/