using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        transform.position = offset + player.position;
    }
}
