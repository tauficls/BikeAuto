using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public bool gameover;
    public GUIStyle style1;
    public Texture image1;
	// Use this for initialization
	void Start () {
        gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Quad")
        {
            Time.timeScale = 0;
            gameover = true;
        }

    }

    void OnGUI()
    {
        if (gameover)
        {
            GUI.Label(new Rect(Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.75f, Screen.height * 0.25f), "Game Over !! ", style1);
            if(GUI.Button(new Rect(Screen.width * 0.48f, Screen.height * 0.55f, 50, 50), image1))
            {
                Application.LoadLevel("minigame");
                Time.timeScale = 1;
            }
        }
    }
}
