using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationCamera : MonoBehaviour
{

    Transform t;


    // Use this for initialization
    void Start()
    {
        t = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

		if (t.position.y < 3.5f)
		{
         t.position += Vector3.up * 0.5f * Time.deltaTime;
         t.Rotate(-Time.deltaTime * 20, 0, 0, Space.World);
		 Debug.Log(t.position.y);
		}
      }


	


        if (Input.GetKey(KeyCode.S))
        {
		
		if (t.position.y > 2.2f)
			{
            t.position += Vector3.down * 0.5f * Time.deltaTime;
            t.Rotate(Time.deltaTime * 20, 0, 0, Space.World);          
			}

		}
	}
}
