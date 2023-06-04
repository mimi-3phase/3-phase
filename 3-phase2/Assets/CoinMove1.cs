using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour

{
	public GameObject targetPosition;

	void Update()
    {
		//dir = (playerpos.position - transform.position).normalized;

		//acceleration = 0.2f;

		float distance = Vector3.Distance(gameObject.transform.position, targetPosition.transform.position);



		if (distance <= 10.0f)

		{

			transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 0.01f);
			Debug.Log("This is player"+transform.position);
		}
	}

}