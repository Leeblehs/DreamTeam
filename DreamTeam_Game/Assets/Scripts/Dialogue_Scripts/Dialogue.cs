using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Look into using XML / Json if the game scales and ends up having a lot of dialogue, external text files for storing conversations.
    http://answers.unity3d.com/answers/63443/view.html <-- How to load one of the files in Unity

    Within the c# script you can then use XmlDocument to parse your xml file(s). This short stackoverflow answer gives you an idea on how this could look like: https://stackoverflow.com/a/55840/6330074
*/

// This class will host all information we need about a single dialogue and will not need to derive from MonoBehaviour
// Need to make it serializable so it can show in the inspector
[System.Serializable]
public class Dialogue 
{
    public string name;
    
    [TextArea(3, 10)] 
    public string[] sentences;
}
