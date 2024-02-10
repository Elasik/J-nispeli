using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyScript : MonoBehaviour
{
    float movementSpeed = 10;

    public GameObject TheEnd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("c"))
        {
            Debug.Log("painettu");
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Osuu");


        if (collision.gameObject.tag == "enemy")
        {
            
            ElamalaskuriScript.LivesAmount -= 1; //vähentää pisteen laskurista
            Destroy(collision.gameObject);
            SoundManagerScript.PlaySound("osuma");
        }

        if (ElamalaskuriScript.LivesAmount == 0) //Kun elämälaskuri on 0, peli päättyy
        {
            
            Destroy(gameObject);
            TheEnd.GetComponent<TheEnd>().ShowTheEnd();
            SoundManagerScript.PlaySound("end");
        }

    }
}
