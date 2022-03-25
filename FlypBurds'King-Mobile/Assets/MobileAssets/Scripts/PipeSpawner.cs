using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float rateSpaw;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= rateSpaw)
        {
            currentTime = 0;
            GameObject tempPrefab = Instantiate(pipe) as GameObject;
            tempPrefab.transform.position = new Vector3(tempPrefab.transform.position.x, Random.Range(-2, 2), tempPrefab.transform.position.z);
        }
    }

}
