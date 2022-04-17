using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
    
    //Touche Z
    if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Touche Z détectée");
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Touche Z détectée, appui long");
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            Debug.Log("Touche Z relachée");
        }
        
        
          //Touche Q
    if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Touche Q détectée");
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Touche Q détectée, appui long");
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Touche Q relachée");
        }
          
       
         //Touche S
    if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Touche S détectée");
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Touche S détectée, appui long");
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("Touche S relachée");
        }

       
          //Touche D
    if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Touche D détectée");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Touche D détectée, appui long");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Touche D relachée");
        }
        
        
        //Clic Gauche
          if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("clic gauche détecté");
        }
    
        //Camera
        // Axe horizontal
        if (Input.GetAxis("Mouse X") > 0) // déplacement vers la droite
        {
            Debug.Log("La souris se déplace ver la droite.");
        }

        if (Input.GetAxis("Mouse X") < 0) // déplacement vers la gauche
        {
            Debug.Log("La souris se déplace ver la gauche.");
        }

        // Axe vertical
        if (Input.GetAxis("Mouse Y") > 0) // déplacement vers le haut
        {
            Debug.Log("La souris se déplace vers le haut.");
        }

        if (Input.GetAxis("Mouse Y") < 0) // déplacement vers le bas
        {
            Debug.Log("La souris se déplace vers le bas.");
        }
    }
}
