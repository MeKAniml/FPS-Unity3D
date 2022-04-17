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
    
    //Touche Z (Avancer)
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
        
        
          //Touche Q (Aller à gauche)
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
          
       
         //Touche S 5aller en arrière)
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

       
          //Touche D (Aller a droite)
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
        
              //Touche R  (Recharger)
    if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Touche R détectée");
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Touche R détectée, appui long");
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("Touche R relachée");
        }
        
        //Clic Gauche (Tirer)
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
