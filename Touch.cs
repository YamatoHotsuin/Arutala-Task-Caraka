using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public Transform Arutala;

    void Update() 
            {
            if (Input.touchCount == 1) {
                UnityEngine.Touch pegang = Input.touches[0];
                if (pegang.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f,pegang.deltaPosition.x,0f);
                }
            if (Input.touchCount == 2) {
                UnityEngine.Touch pegang1 = Input.touches[0];
                UnityEngine.Touch pegang2 = Input.touches[1];

                if (pegang.phase == TouchPhase.Moved)
                {
                   Arutala.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
                }

            }   
        }
    }
}




