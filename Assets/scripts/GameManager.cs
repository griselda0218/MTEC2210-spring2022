using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject carPreFab;
    public Transform[] carSpawnPoints;
    public Color[] carColors;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCar", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SpawnCar();
       // }

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    void SpawnCar()
    {
        int index = Random.Range(0, carSpawnPoints.Length);
        Vector3 spawnPos = carSpawnPoints[index].position;

        GameObject car = Instantiate(carPreFab, spawnPos, Quaternion.identity);


      //  int dirModifier = 0;

      //  if (index > 2)
      //  {
      //      dirModifier = -1;
      //  }
       // else
      //  {
      //      dirModifier = 1;
      //      car.GetComponent<SpiritRenderer>().flipX = true;
      //  }

        int dirModifier = (index > 2) ? -1 : 1;

        float newSpeed = Random.Range(3.0f, 6.9f);

        car.GetComponent<CarMovement>().speed = newSpeed * dirModifier;

        Color c = Color.black;

        if (newSpeed < 4.0f)
        {
            c = carColors[0];
        } else if (newSpeed >= 4.0f && newSpeed < 5.0f)
        {
            c = carColors[1];
        } else if (newSpeed >= 5.0f && newSpeed < 6f)
        {
            c = carColors[2];
        } else
        {
            c = carColors[3];
        }


        car.GetComponent<SpriteRenderer>().color = c;
    }
}
