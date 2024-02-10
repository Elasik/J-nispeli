using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkkanaSpawner : MonoBehaviour
{
    public GameObject porkkana; //ilmestyy editoriin, kenttään raahataan prefabbi
    public GameObject porkkana2;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnObject();
        InvokeRepeating("SpawnObject", 1f, 3f);
        InvokeRepeating("SpawnObject2", 3f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Instantiate(porkkana, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void SpawnObject2()
    {
        Instantiate(porkkana2, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
