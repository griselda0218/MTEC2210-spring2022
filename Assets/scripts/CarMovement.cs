using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5;
  
    void Update()
    {

        float xValue = speed * Time.deltaTime;
        transform.Translate(xValue, 0, 0);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
     
        }
    }

}
