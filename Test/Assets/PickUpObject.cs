using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public TMP_Text coinsText;
    int coins = 0;

    void OnTriggerEnter(Collider collider)
    {
        
            if (collider.gameObject.tag == "Coin")
            {
                coins++;
                coinsText.text = coins.ToString();
                //print(x);
                Destroy(collider.gameObject);
            }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
