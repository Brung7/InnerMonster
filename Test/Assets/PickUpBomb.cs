using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PickUpBomb : MonoBehaviour
{
    private GameObject DeathScrene;
    void Start()
    {
        //RESTART_BUTTON.gameObject.SetActive(false);
    }

    public void Lose()
    {
        DeathScrene.SetActive(true);
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            Camera.main.GetComponent<UIManager>().Lose();
            Time.timeScale = 0f;

            
        }
    }
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
