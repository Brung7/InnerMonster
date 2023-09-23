using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject panaleLose;

    public void Lose()
    {
        panaleLose.SetActive(true);
    }
   
}
