using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Timer))]
public class Timer : MonoBehaviour

{
    private Text timer;
    private float time;

    private void Start()
    {
        timer = GetComponent<Text>();
    }

    public void Update()
    {
        time = Time.realtimeSinceStartup;
        timer.text = string.Format("Time : {0:##.##.###}", time);
    }
}
