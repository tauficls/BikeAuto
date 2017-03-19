using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changePart : MonoBehaviour
{
    public GameObject[] changeObject;
    public Button partButton;
    private int nowPart;
    private const int MAX_PART = 1;
    public GameObject parentObj;
    public GameObject destroyObj;
    public GameObject obj;

    // Use this for initialization
    void Start()
    {
        Button btn = partButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        nowPart = 0;

       
        //for (int i = 0; i < MAX_PART; i++)
        //{
        //    changeObject[i].SetActive(false);
        //}
    }

    void TaskOnClick()
    {
        //changeObject[nowPart].SetActive(true);

        if (nowPart == 0)
        {
            obj.SetActive(true);
            Destroy(destroyObj.transform.GetChild(0).GetChild(4).gameObject);
            changeObject[nowPart].transform.SetParent(parentObj.transform);
            changeObject[nowPart].transform.position = new Vector3(-0.66f, 1.16f, -8.18f);
            changeObject[nowPart].transform.rotation = Quaternion.Euler(7.15f, 90, 0);
            changeObject[nowPart].transform.localScale = new Vector3(2, 2, 2);
        }
        else if (nowPart == 1)
        {
            changeObject[nowPart].transform.position = new Vector3(-1.002f, 1.289f, -8.26f);
            changeObject[nowPart].transform.rotation = Quaternion.Euler(-4.69f, 90, 0);
        }

        Instantiate(changeObject[nowPart]);

        nowPart++;
        if (nowPart >= MAX_PART)
        {
            nowPart = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
