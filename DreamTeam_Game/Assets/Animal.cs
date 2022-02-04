using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This creates a property under the create menu in Unity.
 * If you right click under Create you will see Animal and that will automatically create a new script object for you.
 */
[CreateAssetMenu (fileName ="New Animal", menuName="Animal")]
public class Animal : ScriptableObject
{
    /* Default Key componenets for a scriptable object */
    public new string name; //Ensure to use new keyword here if you would like to use this property. <name> is default value in Scriptable Object Class, using new lets you override that default value.
    //public string description;
    public Animator animator;
    public Sprite artwork;
    
    

    // public Sprite artwork;


    /*
     * Additional value you would like to use for the scriptable object.
     */

    //public int legs; //Included just for the example.

}
