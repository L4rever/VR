using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSwitch : MonoBehaviour
{
    public bool isOn = false;
    public Text textField;
    public Button btn;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ButtonClickInitialized");

        btn.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        isOn = !isOn;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOn) {
            counter++;
            textField.text = counter.ToString();
        }
    }
}
