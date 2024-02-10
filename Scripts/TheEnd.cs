using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowTheEnd()
    {
            gameObject.SetActive(true);
            SoundManagerScript.PlaySound("endSound");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
