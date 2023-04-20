using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float move, moveSpeed, rotation,rotateSpeed;

    void Start()
    {
           moveSpeed = -5f;
        rotateSpeed = 100f;

    }
    //// Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation =  90;
            transform.Rotate(0f, rotation, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation = -90;
            transform.Rotate(0f, rotation, 0f);
        }
    }

    private void LateUpdate()
    {
        transform.Translate(0f, 0f, move);
        
    }

    //public float speed = 5f;

    //private void Update()
    //{
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.position += new Vector3( 0f, 0f, speed * Time.deltaTime);
    //        //rotation += Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
    //        transform.Rotate(0f, 90, 0f);
    //    }

    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.position -= new Vector3( 0f, 0f, speed * Time.deltaTime);
    //    }

    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.position -= new Vector3(speed * Time.deltaTime,0f, 0f);
    //    }

    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        transform.position += new Vector3(speed * Time.deltaTime,0f, 0f );
    //    }
    //}
}
