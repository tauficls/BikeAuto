using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFirebaseUnity;
using SimpleFirebaseUnity.MiniJSON;

public class MoneyScript : MonoBehaviour {
    public int coins;
    public int cost;
    public int nowColor;
    public ArrayList list;
    public bool yes;
    string UID;

    void UpdateOKHandler(Firebase sender, DataSnapshot snapshot)
    {
        Debug.Log("[OK] Update from key: <" + sender.FullKey + ">");
    }

    void UpdateFailHandler(Firebase sender, FirebaseError err)
    {
        Debug.Log("[ERR] Update from key: <" + sender.FullKey + ">, " + err.Message + " (" + (int)err.Status + ")");
    }
    void Start()
    {

        UID = PlayerPrefs.GetString("UID");
        list = new ArrayList();
    }
    public void substractCoin()
    {
        Firebase firebase = Firebase.CreateNew("bikers-6dcf1.firebaseio.com");
        Firebase user = firebase.Child("User", true).Child(UID, true);
        user.OnUpdateSuccess += UpdateOKHandler;
        user.OnUpdateFailed += UpdateFailHandler;
        firebase.OnUpdateSuccess += UpdateOKHandler;
        firebase.OnUpdateFailed += UpdateFailHandler;

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
        Dictionary<string, object> data = new Dictionary<string, object>();
        data.Add("money", coins);
        user.UpdateValue(data);
    }
}
