using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kettu2Script : KettuScript
{
    public float x;
    public float y;
    public float speed = 10f;
    Rigidbody2D rb;
    void Start()
    {
        y = Random.Range(-6, -9);
        x = Random.Range(-5, 5);
        transform.position = new Vector2(x, y);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.y > 10)
        {
            Destroy(this.gameObject);
        }
    }

}
