using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {
	public GameManager gameManager;

	public Transform rayStart;
	private Animator anim;

	private Rigidbody rb;
	private bool walkRight = true;
	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody>();
		anim= GetComponent<Animator>();
		gameManager = FindObjectOfType<GameManager>();
	}

	void FixedUpdate()
	{
		if (!gameManager.gameStarted)
		{
			return;
		}
		else
		{
			anim.SetTrigger("GameStarted");
		}
			rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
	}
	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Switch();
		}
		RaycastHit hit;
		if (!Physics.Raycast(rayStart.position, -transform.up, out hit, Mathf.Infinity)) {
			anim.SetTrigger("IsFalling");
		}
	}
    void Switch(){
		walkRight = !walkRight;
		if (walkRight)
		{
			transform.rotation = Quaternion.Euler(0f, 45f, 0f);
		}
		else
		{
			transform.rotation = Quaternion.Euler(0, -45, 0);
		}
	}	
}
