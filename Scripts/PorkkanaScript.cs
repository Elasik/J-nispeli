using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkkanaScript : MonoBehaviour
{
    float x;
    float y;

    // Start is called before the first frame update
    public void Start()
    {
        x = Random.Range(-4,4); //määrittelee arvottavan sijainnin alueen, jossa ilmestyy
        y = Random.Range(-4,4);
        transform.position = new Vector2(x, y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Object.Destroy(gameObject, 3.0f); //objekti katoaa määritetyn ajan kuluttua

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PistelaskuriScript.pointAmount += 1; //lisää pisteen osumasta pointAmountiin
            //Debug.Log("1 piste");
            Destroy(gameObject);
            SoundManagerScript.PlaySound("piste");
        }
    }
}
