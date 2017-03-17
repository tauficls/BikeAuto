using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMaterial : MonoBehaviour {
    public Material[] material;
    Renderer rend;
    public Button yourButton;
    int nowColor = 0;
    int cost = 1000;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        
        nowColor = PlayerPrefs.GetInt("Now Color");
        rend.sharedMaterial = material[nowColor];
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}

    void TaskOnClick()
    {
        Debug.Log("tes");
        nowColor++;
        PlayerPrefs.SetInt("Cost", cost);
        if (nowColor >= material.Length)
        {
            nowColor = 0;
        }
        PlayerPrefs.SetInt("Now Color", nowColor);
        rend.sharedMaterial = material[nowColor];
    }
}
