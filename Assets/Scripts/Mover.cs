using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward;
	}
}
