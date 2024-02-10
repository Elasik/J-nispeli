using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KettuScript : MonoBehaviour
{
    // x näkyy editorissa, koska on public
    
     float x;
     float y;
    


    // Start is called before the first frame update
    void Start()
    {
        y = Random.Range(6,9);
        x = Random.Range(-5, 5);
        transform.position = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate()
    {
        if (gameObject.transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }

}
