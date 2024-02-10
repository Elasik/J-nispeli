using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KettuSpawner : MonoBehaviour
{

    
    public GameObject kettu;
    public GameObject kettu2;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnKettu", 3f, 4f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnKettu()
    {
        Instantiate(kettu, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(kettu2, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
