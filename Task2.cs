using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task2 : MonoBehaviour
{
    public GameObject showing;
    private int _seconds;
    private int _minutes;
    private int _hours;

void Start()
    {
    string time = System.DateTime.UtcNow.ToLocalTime().ToString("hh:mm tt");
    showing.GetComponent<Text>(). text = time;
    }



}
