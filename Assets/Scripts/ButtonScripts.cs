using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScripts : MonoBehaviour
{

    public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		CopyStringToClipboard(SystemInfo.deviceUniqueIdentifier);
	}

    public void CopyStringToClipboard(string str)
    {
        GUIUtility.systemCopyBuffer = str;
        yourButton.GetComponentInChildren<TMP_Text>().text = "Copied";
        
    }
}
