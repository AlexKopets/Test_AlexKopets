using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBomb : MonoBehaviour
{
    private float bomb_Time = 5;
    private bool bomb_TimeOn = false; 
    // Start is called before the first frame update
    void Start()
    {
        bomb_TimeOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (bomb_Time > 0)
        {
            bomb_Time -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
            bomb_TimeOn = false;
        }
    }
}
