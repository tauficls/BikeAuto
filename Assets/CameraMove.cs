using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public int speed;
    public int sc;
    public float score;
    public GUIStyle style1;
    
	// Use this for initialization
	void Start () {
        score = 1;
        sc = 1;
	}
	
	// Update is called once per frame
	void Update () {
        speed = PlayerPrefs.GetInt("Speed");

        Debug.Log("Speed" + PlayerPrefs.GetInt("Speed"));
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        score += Time.deltaTime * 10;
        sc = (int) score;
        if(sc % 200 == 0)
        {
            speed++;
            PlayerPrefs.SetInt("Speed", speed);
            
        }
        PlayerPrefs.SetInt("Score", sc);
	}

    void OnGUI()
    {
        string scores = sc.ToString();

        GUI.Label(new Rect(Screen.width * 0.8f, Screen.height * 0.07f, Screen.width * 0.2f, Screen.height * 0.05f), "high " + scores,style1);
    }
}
