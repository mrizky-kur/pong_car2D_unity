using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padle2 : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.I;
    public KeyCode moveDown = KeyCode.K;
    public KeyCode moveLeft = KeyCode.J;
    public KeyCode moveRight = KeyCode.L;
    public float speed = 5;
    private Rigidbody2D rb2d;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
    if (Input.GetKey(moveUp)) {
        vel.y = speed;
    }
    else if (Input.GetKey(moveDown)) {
        vel.y = -speed;
    }
    else if (Input.GetKey(moveLeft)) {
        vel.x = -speed;
    }
    else if (Input.GetKey(moveRight)) {
        vel.x = speed;
    }
    else {
        vel.y = 0;
        vel.x = 0;
    }
    rb2d.velocity = vel;

    var pos = transform.position;
    transform.position = pos;
}
public void Reset(){
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
    }