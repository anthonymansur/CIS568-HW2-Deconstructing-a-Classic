using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        pointValue = 10;
    }

    public GameObject deathExplosion;
    public void Die()
    {
        /**
         * All of shuriken's particle effects by default use the convention of Z being upwards, 
         * and XY being the horizontal plane. As a result, since we are looking down the Y axis, we rotate 
         * the particle system so that it flys in the right way.
         */
        Instantiate(deathExplosion, gameObject.transform.position, Quaternion.AngleAxis(-90, Vector3.right));

        GameObject obj = GameObject.Find("GlobalObject");
        Global g = obj.GetComponent<Global>();
        g.score += pointValue;

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
