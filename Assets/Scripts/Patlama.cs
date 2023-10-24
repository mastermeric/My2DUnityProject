using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patlama : MonoBehaviour
{
    RaycastHit carpma;
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        print(cam.name);
    }

    
    void Update()
    {
        //Draw Ray..
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x = 20f;
        mousePosition = cam.ScreenToWorldPoint(mousePosition);
        Debug.DrawRay(transform.position, mousePosition - transform.position, Color.red);

        //Ray isin = cam.ScreenPointToRay(Input.mousePosition);
        //Physics.Raycast(isin, out carpma); // Isinin dokunmasına ait "carpma" bilgisini yayinlariz.
        //Debug.DrawRay(isin.origin, isin.direction * 100f, Color.red); // 100 birimlik isin gonderir

    }
}
