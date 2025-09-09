using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowsChar : MonoBehaviour {

	public Transform target;
	private Vector3 offset;
	// Use this for initialization
	void Awake () {
		offset = transform.position-target.position;
	}
	void LateUpdate()
	{
		transform.position = target.position+offset;
	}
	
}
