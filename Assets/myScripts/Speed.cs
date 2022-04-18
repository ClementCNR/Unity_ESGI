using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof(Speed))]
public class Speed : MonoBehaviour
{

    private Text speed;
    private float controlSpeed = 0;
    //public CarController control = new CarController();
    public CarController control;
    // Start is called before the first frame update
    void Start()
    {
        speed = GetComponent<Text>();
        control = GameObject.Find("Car").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        controlSpeed = control.CurrentSpeed;

        if(controlSpeed == 0)
        {
            speed.text = string.Format("Speed : 0 Km/h");
        }
        else if(controlSpeed >= 0)
        {
            speed.text = string.Format("Speed : {0:###} Km/h", controlSpeed);
        }
        else
        {
            speed.text = string.Format("Speed : -{0:###} Km/h", controlSpeed);
        }
 
        
    }
}
