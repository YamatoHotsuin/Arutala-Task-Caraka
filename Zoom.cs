using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject Arutala;
    void Start()
    {
        
    }
    public int i;
    // Update is called once per frame
     float initialFingersDistance;
    Vector3 initialScale;
    void Update()
    {
        if(Input.touches.Length == 2)
        {
            UnityEngine.Touch t1 = Input.touches[0];
            UnityEngine.Touch t2 = Input.touches[1];
           
            if (t1.phase == TouchPhase.Began || t2.phase == TouchPhase.Began)
            {
                initialFingersDistance = Vector2.Distance(t1.position, t2.position);
                initialScale = Arutala.transform.localScale;
            }
            else if(t1.phase == TouchPhase.Moved || t2.phase == TouchPhase.Moved)
            {
                var currentFingersDistance = Vector2.Distance(t1.position, t2.position);
                var scaleFactor = currentFingersDistance / initialFingersDistance;
                Arutala.transform.localScale = initialScale * scaleFactor;
            }
        }
    }
}


