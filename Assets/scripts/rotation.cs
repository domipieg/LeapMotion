using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class rotation : MonoBehaviour {



    Transform t;

    // Use this for initialization
    void Start () {
        t = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.A))
            t.Rotate(0, Time.deltaTime*30,0, Space.World);

        if (Input.GetKey(KeyCode.D))
            t.Rotate(0, -Time.deltaTime * 30, 0, Space.World);

    }

}

