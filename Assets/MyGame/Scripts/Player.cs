using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    int countCollision = 0;
    public int points = 0;
    public TextMeshProUGUI scoreDisplay;
    public int speed;
    public GameOverScreen GameOverScreen;
    public GameObject timerDeactivation;

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
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        }

        if (collision.name.Contains("Present"))
        {
            points++;
            countCollision++;
            scoreDisplay.text = points.ToString();
            Destroy(collision.gameObject);
  
        }

        if (collision.name.Contains("GameOverCollider"))
        {
            GameOver();
            timerDeactivation.SetActive(false);


        }
        
        Debug.Log("count collisions" + countCollision);
        Debug.Log("IN PLAYER: Collide with " + collision.name);
    }

    public void GameOver()
    {
        GameOverScreen.Setup(countCollision);
    }


}
