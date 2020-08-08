using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawned : MonoBehaviour {
    public GameObject[] planets;
    int planetno;
    public float maxpos = 2.7f;
    public float delayTimer = 1f;
    float timer;

	// Use this for initialization
	void Start () {
        timer = delayTimer;
       
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        { 


            Vector3 planetpos = new Vector3(Random.Range(-2.7f, 2.7f), transform.position.y, transform.position.z);
            planetno = Random.Range(0, 3);
            Instantiate(planets[planetno], planetpos, transform.rotation);
            timer = delayTimer;
        }
    }
}
