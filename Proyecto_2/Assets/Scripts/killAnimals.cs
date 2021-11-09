using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killAnimals : MonoBehaviour
{
    private float forwardLim = 50f;
    private float backLim = -17f;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > forwardLim)
        { Destroy(gameObject); }

        if (transform.localPosition.z < backLim)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            player = GameObject.Find("Granjero");
            Destroy(player);
            Time.timeScale = 0;
        }

    }
}
