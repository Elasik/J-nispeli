using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElamalaskuriScript : MonoBehaviour
{
    Text livesText;
    public static int LivesAmount = 5;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = LivesAmount.ToString();
    }
}
