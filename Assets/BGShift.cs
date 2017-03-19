using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGShift : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit2D(Collider2D collider)
    {
        float width = ((BoxCollider2D)collider).size.x;
        Vector3 pos = collider.transform.position;
        pos.x += width * 1.95f;
        if (collider.gameObject.tag == "Background1")
        {
            collider.transform.position = pos;
        }
        if (collider.gameObject.tag == "Background2")
        {
            collider.transform.position = pos;
        }
        
    }
}
