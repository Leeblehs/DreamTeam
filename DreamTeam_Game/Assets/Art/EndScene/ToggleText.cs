using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleText : MonoBehaviour
{
    public TextMeshProUGUI DisplayedText;

    public void OnOffText()
    {
        if (DisplayedText.enabled == true)
        {
            DisplayedText.enabled = false;
        }
        else
        {
            DisplayedText.enabled = true;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
