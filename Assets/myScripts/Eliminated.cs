using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class Eliminated : MonoBehaviour
{
    // Trigger = boite de collision ou collider 
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider col) // se lit qd col entre ds la boite de collision (le trigger) de l'objet à qui le script est associé
                                      // col correspond à l'objet qui entre dans la zone
    {
        if (/*col.name == "ColliderBottom" || */col.name == "ColliderBody"/* || col.name == "ColliderFront"*/)        // ColliderBottom == hitbox de la voiture
        {

            Transform.Destroy(GetComponent<CarController>());

            string s = string.Format("Car {0} eliminated", col.name);
            print(s);
            //anim.Play(";


        }

    }

}