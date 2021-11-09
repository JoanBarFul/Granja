using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 10;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float rightlim = 23;

    public GameObject projectilePrefab;
    



    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput); 

        if (transform.position.x >= rightlim)
        { transform.position = new Vector3(rightlim, 0, -10); }

        if (transform.position.x <= -rightlim)
        { transform.position = new Vector3(-rightlim, 0, -10); }

        if (Input.GetKeyDown(KeyCode.Space))
        { Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); }
    }
}
