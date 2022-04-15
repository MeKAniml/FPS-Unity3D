using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if(col.name == "Zone de boss"){
            print("Le boss spawn")
        }
        if(col.name == "Niveau suivant"){
            print("Passage au prochain niveau")
        }
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}