using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public float deadZone = -40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void destroyPipe()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        destroyPipe();
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime; ;
    }

}
