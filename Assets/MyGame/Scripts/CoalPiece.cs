using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalPiece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CoalPiece");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("IN COALPIECE: Collide with " + collision.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
