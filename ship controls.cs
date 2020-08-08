using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontrols : MonoBehaviour {
    public float shipspeed;

    public float maxpos = 2.3f;

    Vector3 position;


	// Use this for initialization
	void Start () {
        position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis ("Horizontal") * shipspeed * Time.deltaTime;
      position.x =  Mathf.Clamp(position.x, -2.3f, 2.2f);

        transform.position = position;
        
            }


     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        } 
    }

}
