using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Inputs : MonoBehaviour // classe Input permet de r?cup?rer les touches, souris utilis?es pour effectuer des actions
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Touche Z d?tect?e");
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Touche Z d?tect?e, appui long");
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            Debug.Log("Touche Z relach?e");
        }

        if (Input.GetMouseButtonDown(0)) // clic souris gauche, marche comme GetKey
        {
            Debug.Log("clic gauche d?tect?");
        }

        if (Input.GetMouseButton(1)) // clic souris gauche, marche comme GetKey
        {
            Debug.Log("clic droit long");
        }


        // GetButton: edit->project sttings->input manager, pour ?diter des boutons
        if (Input.GetButtonDown("interaction")) // on appuie sur le bouton interaction
        {
            Debug.Log("interaction avec clic a");
        }

        // GetAxis: pour r?cup?rer les axes, permet d'enregistrer les mvts de la souris
        // Axe horizontal
        if (Input.GetAxis("Mouse X") > 0) // d?placement vers la droite
        {
            Debug.Log("La souris se d?place ver la droite.");
        }

        if (Input.GetAxis("Mouse X") < 0) // d?placement vers la gauche
        {
            Debug.Log("La souris se d?place ver la gauche.");
        }

        // Axe vertical
        if (Input.GetAxis("Mouse Y") > 0) // d?placement vers le haut
        {
            Debug.Log("La souris se d?place vers le haut.");
        }

        if (Input.GetAxis("Mouse Y") < 0) // d?placement vers le bas
        {
            Debug.Log("La souris se d?place vers le bas.");
        }



    }
}
