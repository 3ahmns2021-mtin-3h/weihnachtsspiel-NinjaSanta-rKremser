using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int countCollision = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "Present")
        {
            Debug.Log("in if in Present + 1");
            countCollision++;
        }

        Debug.Log("count collisions" + countCollision);
        Debug.Log("IN PLAYER: Collide with " + collision.name);
    }
}
