using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SystemInfoScript : MonoBehaviour {
    public TMP_Text  description;

    void Start() {
        description.text = SystemInfo.deviceUniqueIdentifier;
    }
}