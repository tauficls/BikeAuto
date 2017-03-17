using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    [SerializeField]
    private Text moneyValue = null;
    int value = 5000;
	// Use this for initialization
	void Start () {
        moneyValue.text = value.ToString();
        PlayerPrefs.SetInt("Money Value", value);
	}
	
	// Update is called once per frame
	void Update () {
        value = PlayerPrefs.GetInt("Money Value");
        moneyValue.text = value.ToString();
	}
}
