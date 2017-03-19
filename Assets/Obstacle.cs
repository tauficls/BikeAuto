using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public GameObject[] obj;
    public Transform campos;
	
    // Use this for initialization
	void Start () {
        createObstacle();
	}

    // Update is called once per frame
    void Update() {
        
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("Speed") * Time.deltaTime);
        GameObject cs = GameObject.Find("Quad");
        if (campos.position.x - cs.transform.position.x > 25 || PlayerPrefs.GetInt("Score") % 25 == 0) 
        {
            Destroy(cs);
        }
	}

    void createObstacle()
    {
        GameObject clone = (GameObject) Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        clone.name = "Quad";
        clone.AddComponent<BoxCollider2D>();
        clone.GetComponent<BoxCollider2D>().isTrigger = true;
        float xx = Random.Range(2, 5);
        Invoke("createObstacle", xx);
    }


}
