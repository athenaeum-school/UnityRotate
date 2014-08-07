using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	void Start() {

	}

	void Update() {
		if(Input.GetKey(KeyCode.LeftArrow)) 
		 RotLeft ();
	}

	public void RotLeft()
	{
		transform.Rotate(0,0, 60 * Time.deltaTime);
	}
	
	public void RotRight()
	{
		transform.Rotate(0,0,-60 * Time.deltaTime);
	}
}
