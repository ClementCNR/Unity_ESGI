using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Trigger = boite de collision ou collider 

    void OnTriggerEnter(Collider col) // se lit qd col entre ds la boite de collision (le trigger) de l'objet à qui le script est associé
                                      // col correspond à l'objet qui entre dans la zone
    {
        if (col.name == "ColliderBottom")        // ColliderBottom == hitbox de la voiture
        {
            float time = Time.realtimeSinceStartup;
            string s = string.Format("Reached checkpoint in {0:##.###}", time);
            print(s);
        }
        
    }

}
