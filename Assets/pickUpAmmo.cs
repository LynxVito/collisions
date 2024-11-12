using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    int ammoCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "AmmoBox") {
            other.gameObject.SetActive(false);
            ammoCount += 20;
        }
    }
}
