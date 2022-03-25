using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{   

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * -5 * Time.deltaTime;
    }
}
