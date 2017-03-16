using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transformObject : MonoBehaviour {
    public Button whellButton;
    private int form;
    private const int MAX_FORM = 3;
    private Vector3 initForm;

	// Use this for initialization
	void Start () {
        Button btn = whellButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        initForm = transform.localScale;
        form = 2;
	}

    void scaleObject(float scale)
    {
        if (scale > 0)
        {
            transform.localScale = initForm + new Vector3(0, scale, 0);
            foreach (Transform child in transform)
            {
                child.localScale = initForm + new Vector3(0, scale, 0);
            }
        }
        else
        {
            scale *= -1;
            transform.localScale = initForm - new Vector3(0, scale, 0);
            foreach (Transform child in transform)
            {
                child.localScale = initForm - new Vector3(0, scale, 0);
            }
        }
    }

	// Update is called once per frame
    void TaskOnClick()
    {
        if (form == 1)
        {
            scaleObject(0);
        }
        else if (form == 2)
        {
            scaleObject(0.4f);
        }
        else if (form == 3)
        {
            scaleObject(-0.3f);
        }

        form++;
        if (form > MAX_FORM)
        {
            form = 1;
        }
	}
}
