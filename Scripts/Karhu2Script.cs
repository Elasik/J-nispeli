using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karhu2Script : MonoBehaviour
{
    public float x;
    public float y;
    public float speed = 10f;
    Rigidbody2D rb;

    void Start()
    {
        y = Random.Range(-5, 5);
        x = Random.Range(-6, -9);
        transform.position = new Vector2(x, y);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.x > 10)
        {
            Destroy(this.gameObject);
        }
    }

}
