using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarhuSpawner : MonoBehaviour
{
    // ilmestyy editoriin. Kenttään raahataan haluttu prefab
    public GameObject karhu;
    public GameObject karhu2;
   

    // Start is called before the first frame update
    void Start()
    {
        
        
        InvokeRepeating("SpawnKarhu", 4f, 6f);
        

       

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void SpawnKarhu()
    {
        Instantiate(karhu, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(karhu2, new Vector3(0, 0, 0), Quaternion.identity);
    }


}
