using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuelSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("App Started.. Done.. " + DateTime.Now);
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            Vector2 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -5), ForceMode2D.Impulse);

            Vector2 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            Vector2 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -5), ForceMode2D.Impulse);

            Vector2 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }


    }
}
