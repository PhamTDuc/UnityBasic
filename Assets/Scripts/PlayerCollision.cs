using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	private PlayerMove playerMove;
	private GameManager gameManager;
	
	void Start()
	{
		playerMove = this.GetComponent<PlayerMove>();
		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

	}

    void OnCollisionEnter(Collision collision)
    {
    	if(collision.collider.tag == "Obstacle")
    	{   
    		Debug.Log("We have hit " + collision.collider.name);
			playerMove.enabled = false;
			gameManager.EndGame();
    	}
    }
}
