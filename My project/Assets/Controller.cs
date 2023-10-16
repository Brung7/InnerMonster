using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
   public GameObject go;

   private IControllable controllableObject;

    private void Start()
    {
        controllableObject = go.GetComponent<IControllable>();
        if (controllableObject == null)
            throw new NullReferenceException("go don't have Controller interface");
    }

   private void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            controllableObject.Move();
        }
    }
}
