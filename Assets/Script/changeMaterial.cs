using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMaterial : MonoBehaviour {
    public Material[] material;
    Renderer rend;
    public Button yourButton;
    int nowColor = 0;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}

    void TaskOnClick()
    {
        Debug.Log("tes");
        nowColor++;
        if (nowColor >= material.Length)
        {
            nowColor = 0;
        }
        rend.sharedMaterial = material[nowColor];
    }
}
