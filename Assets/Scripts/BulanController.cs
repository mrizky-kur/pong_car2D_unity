using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulanController : MonoBehaviour

{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Ball"))
        {
            print("oli diambil menambah kecepatan mobil ");
            Destroy(gameObject);
        }
    }


}