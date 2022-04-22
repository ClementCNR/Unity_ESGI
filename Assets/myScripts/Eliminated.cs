using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class Eliminated : MonoBehaviour
{
    // Trigger = boite de collision ou collider 
    public Animation anim;
    public GameObject player;


    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    void OnTriggerExit(Collider col) // se lit qd col sort de la boite de collision (le trigger) de l'objet à qui le script est associé
                                      // col correspond à l'objet qui entre dans la zone
    {
        if (col.name == "ColliderBody")        // ColliderBottom == hitbox de la voiture
        {

            if(col.CompareTag("Player"))
            {
                print("Joueur elimine");

                Destroy(col.gameObject);
                //Destroy(player);
                //Destroy(col.transform.parent.parent.gameObject);
                
            }
            else
            {
                string s = string.Format("Enemi {0} elimine", col.GetInstanceID());
                print(s);
                Destroy(col.transform.parent.parent.gameObject);
            }

            //anim.Play("anim");


        }

    }



}