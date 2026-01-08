using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;
    void FixedUpdate ()
    {
       Debug.Log("FixedUpdate time : " + Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time : " + Time.deltaTime);
    }
}
