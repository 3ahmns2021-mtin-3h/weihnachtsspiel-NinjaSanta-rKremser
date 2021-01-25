using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    int countCollision = 0;
    public int points = 0;
    public TextMeshProUGUI scoreDisplay;

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

        if (collision.name.Contains("Coalpiece"))
        { 
            Destroy(collision.gameObject);
            transform.position = new Vector3()
        }

        if (collision.name.Contains("Present"))
        {
            points++;
            countCollision++;
            scoreDisplay.text = points.ToString();
            Destroy(collision.gameObject);
  
        }

        Debug.Log("count collisions" + countCollision);
        Debug.Log("IN PLAYER: Collide with " + collision.name);
    }
}
