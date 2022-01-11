using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckControl : MonoBehaviour
{
    private float flag;
    private float zRange = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z == -zRange)
        { flag = 0.005f; }
        if (transform.position.z == zRange)
        { flag = -0.005f; }
        transform.Translate(0, 0, flag);
    }
}
