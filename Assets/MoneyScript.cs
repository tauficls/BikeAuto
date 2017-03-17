using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour {
    public int coins;
    public int cost;
    public int nowColor;
    public ArrayList list;
    public bool yes;
    void Start()
    {
        list = new ArrayList();
    }
    public void substractCoin()
    {
        yes = false;
        coins = PlayerPrefs.GetInt("Money Value");
        cost = PlayerPrefs.GetInt("Cost");
        nowColor = PlayerPrefs.GetInt("Now Color");
        
        if (coins - cost > 0) {
            Debug.Log("coba");
            foreach (int i in list)
            {
                if (i == nowColor)
                {
                    yes = true;
                    break;
                }
            }
            if(yes == false)
            {
                list.Add(nowColor);
                coins -= cost;
            }
        }
        PlayerPrefs.SetInt("Money Value", coins);
    }
}
