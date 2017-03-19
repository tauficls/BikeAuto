using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public int jumpHeight;
    public bool touch;
    public int speed;
	// Use this for initialization
	void Start () {
        jumpHeight = 7;
        touch = false;
        speed = 5;
        PlayerPrefs.SetInt("Speed", speed);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("Speed") * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && touch == true)
        {

            touch = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        }
	}

    void OnCollisionEnter2D()
    {
        Debug.Log("Touch");
        touch = true;

    }
}
