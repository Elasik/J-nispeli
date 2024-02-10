using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porkkana2Script : PorkkanaScript
{

    void FixedUpdate()
    {
        Object.Destroy(gameObject, 1.0f); //objekti katoaa määritetyn ajan kuluttua

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PistelaskuriScript.pointAmount += 2; //lisää pisteet osumasta pointAmountiin
            Destroy(gameObject);
            SoundManagerScript.PlaySound("piste");
        }
    }
}
