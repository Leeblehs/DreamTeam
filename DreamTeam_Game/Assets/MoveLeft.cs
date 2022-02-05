using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] bool reachedTarget;
    [SerializeField] float speed;
    private Vector2 velocity;


    public void GoLeft() {
        reachedTarget = true;
        velocity = target.position - transform.position;
        velocity.Normalize();
    }

    public void Update()
    {
        if (reachedTarget) {
            transform.Translate(velocity * speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, target.position) <= 0.05) {
                reachedTarget = false;
            }
        }
    }
}
