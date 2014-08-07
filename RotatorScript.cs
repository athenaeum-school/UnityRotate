using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour
{
	GameObject cubeOne;
	
	void Start ()
	{
		cubeOne = GameObject.Find("Cube");
	}
	
	void update()
	{
		if(Input.GetKey(KeyCode.Return))
		{
			cubeOne.GetComponent<Rotator>().RotLeft();
		}
	}
}
