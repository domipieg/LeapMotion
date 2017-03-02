using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour {

		Vector3 start;
		Vector3 end ;
		Color color ;
		Transform parent;

		
	// Use this for initialization
	void Start () {
		
		parent = GetComponent<Transform>();
		 start = new Vector3(0,0,0);
		 end = new Vector3(-2,3,0);
		 color = new Color(1, 0, 0);
		
		
		DrawLine(start, end, color);
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	

     void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 1000)
             {
                 GameObject myLine = new GameObject();
				 myLine.transform.SetParent(parent);
				 myLine.transform.position = start;				 
                 myLine.AddComponent<LineRenderer>();
                 LineRenderer lr = myLine.GetComponent<LineRenderer>();
                 lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
				// lr.transform.SetParent(parent);

                 lr.SetColors(color, color);
                 lr.SetWidth(0.1f, 0.1f);
                 lr.SetPosition(0, start);
                 lr.SetPosition(1, end);
				 lr.useWorldSpace = false;
                 //GameObject.Destroy(myLine, duration);
             }


}
