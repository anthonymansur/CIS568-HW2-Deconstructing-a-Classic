using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    public GameObject objToSpawn;
    public float timer;
    public float spawnPeriod;
    public int numberSpawnedEachPeriod;
    public Vector3 originInScreenCoords;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timer = 0;
        spawnPeriod = 5.0f;
        numberSpawnedEachPeriod = 3;

        originInScreenCoords = Camera.main.WorldToScreenPoint(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnPeriod)
        {
            timer = 0;

            float width = Screen.width;
            float height = Screen.height;

            for (int i = 0; i < numberSpawnedEachPeriod; i++)
            {
                // randomly find the horizontal and vertical position of the
                // asteroid to spawn
                float horizontalPos = Random.Range(0.0f, width);
                float verticalPos = Random.Range(0.0f, height);

                Instantiate(objToSpawn,
                    Camera.main.ScreenToWorldPoint(
                        new Vector3(horizontalPos,
                        verticalPos, originInScreenCoords.z)),
                    Quaternion.identity);
            }
        }
    }
}
