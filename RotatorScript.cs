using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour
{
	GameObject cubeOne;
	//Rotator rotateOne;
	
	void Start ()
	{
		cubeOne = GameObject.Find("Cube");
		Debug.Log(cubeOne);
		//rotateOne = GameObject.Find("Cube").GetComponent<Rotator>();
		Debug.Log("Start");
	}
	
	void update()
	{
		Debug.Log("Update");
		if(Input.GetKey(KeyCode.Return))
		{
			//rotateOne.RotLeft();
			cubeOne.GetComponent<Rotator>().RotLeft();
			Debug.Log("LeftArrow");
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			//rotateOne.RotRight();
			cubeOne.GetComponent<Rotator>().RotRight();
			Debug.Log("RightArrow");
		}
	}
}
