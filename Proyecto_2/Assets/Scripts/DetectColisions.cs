using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherTrigger)
    {
        Destroy(otherTrigger.gameObject);
        Destroy(gameObject);
    }
}
