using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipeSpeed = 20;
    public float deadZone = -60;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left*pipeSpeed)* Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
