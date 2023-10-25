using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingRaycast : MonoBehaviour
{
    //RaycastHit2D ates;
    public float distance = 100f;
    public LayerMask hedefKatman;
    public float speed = 1.0f;

    string donusYonu = "sol";

    private void Update()
    {
        RaycastHit vurus;
        float degreesPerSecond = 45.0f;

        Debug.Log("Y --> " + transform.rotation.eulerAngles.y);

        if (donusYonu.Equals("sol"))
        {
            if (transform.rotation.eulerAngles.y > 180.0)
            {
                donusYonu = "sag";
            }
            transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
        }

        if (donusYonu.Equals("sag"))
        {
            if (transform.rotation.eulerAngles.y <= 1.0)
            {
                donusYonu = "sol";
            }

            transform.Rotate(new Vector3(0, -degreesPerSecond, 0) * Time.deltaTime);
        }


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out vurus, Mathf.Infinity, hedefKatman))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * vurus.distance, Color.green);
            //Debug.Log("Hedefi Vurduk : " + vurus.distance );
        }
        else
        {
            Debug.DrawRay(transform.position, transform.position + transform.right * distance, Color.red);
            //Debug.Log("Hedefi Iskaladık");
        }



        /*
        ates = Physics2D.Raycast(transform.position, transform.forward, distance);
        
        if (ates.collider)
        {            
            Debug.DrawRay(transform.position, ates.point, Color.green);
            Debug.Log("Hedefi Vurduk");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.position + transform.forward*distance, Color.red);
            Debug.Log("Hedefi Iskaladık");
        }
        */

    }
}
