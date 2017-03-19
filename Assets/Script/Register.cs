using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using LitJson;


public class Register : MonoBehaviour {
    public GameObject email;
    public GameObject pass;
    private string Email;
    private string Pass;
    private string UID;

    // Use this for initialization
    void Start () {
		
	}
	
    public void WWWRegister()
    {
        string url = "https://www.googleapis.com/identitytoolkit/v3/relyingparty/verifyPassword?key=AIzaSyCxIdBIUWdSo-kEYk1w_OmctTpI_drUYr8";
        Debug.Log(url);

        //Header
        //Dictionary<string, string> postHeader = new Dictionary<string, string>();
        //postHeader.Add("Content-Type", "\"application/json\"");
        

        //Header
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Content-Type", "application/json");

        //Body
        string data = "{email: \""+Email +"\", password: \""+ Pass + "\", returnSecureToken: true}";
        byte[] rawData = Encoding.ASCII.GetBytes(data);

        WWW www = new WWW(url, rawData, headers);
        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.data);


            JsonData jsonObj = JsonMapper.ToObject(www.text);
           
            UID  = jsonObj["localId"].ToString();
            PlayerPrefs.SetString("UID", UID);
            Debug.Log(UID);
            Application.LoadLevel("tes");
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (email.GetComponent<InputField>().isFocused)
            {
                pass.GetComponent<InputField>().Select();
            }
          
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("WORK!");
            WWWRegister();
        }
        Email = email.GetComponent<InputField>().text;
        Pass = pass.GetComponent<InputField>().text;
        
    }
}
