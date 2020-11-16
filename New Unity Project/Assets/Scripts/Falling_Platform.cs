using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Platform : MonoBehaviour
{

    public float fallingTime;

    private TargetJoint2D joint;
    private BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<TargetJoint2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("falling",fallingTime);
        }
    }

    void falling()
    {
        joint.enabled = false;
        collider.isTrigger = true;
    }
}
