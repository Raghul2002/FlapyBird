using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate=4;
    public float timer=2;
    public float heightOfSet = 11;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lowestPoint = transform.position.y - heightOfSet;
        float heighestPoint = transform.position.y + heightOfSet;
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipe,new Vector3(transform.position.x, Random.Range(lowestPoint,heighestPoint),0), transform.rotation);
            timer = 0;
        }
    }
}
