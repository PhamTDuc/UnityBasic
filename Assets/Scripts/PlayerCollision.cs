using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	PlayerMove playerMove;

	void Start()
	{
		playerMove = this.GetComponent<PlayerMove>();
	}
    void OnCollisionEnter(Collision collision)
    {
    	if(collision.collider.tag == "Obstacle")
    	{   
    		// Debug.Log("We have hit " + collision.collider.name);
			if(playerMove != null)
			{
				playerMove.enabled = false;
				GameManger gameManger = FindObjectOfType<GameManager>();
				if (gameManger != null)
				{
					gameManger.EndGame();
				}
			}
    	}
    }
}
