using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    public float lowestPoint;
    public float heighestPoint;
    void spawnPipe()
    {
        //lowestPoint = transform.position.y - (heightOffset*0.5f);
        //heighestPoint = transform.position.y + (heightOffset * 0.5f);
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,heighestPoint),0), transform.rotation);
    }
}
