using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpeed : MonoBehaviour
{
    // speed control
    public float animationSpeed = 1.0f;
    public float speedMultiplier = 1.2f;

    Animator spriteSpeed;

    // Start is called before the first frame update
    void Start()
    {
        spriteSpeed = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteSpeed.speed = animationSpeed * speedMultiplier;
    }
}