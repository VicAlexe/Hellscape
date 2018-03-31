using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthOfFieldManager : MonoBehaviour 
{
	[SerializeField]
	private LayerMask rayMask;

	[SerializeField]
	private float maxDistance;

	[SerializeField]
	private Transform depthOfFieldObject;

	[SerializeField]
	private float thing;

	private RaycastHit hit;


	void Update()
	{
		if (Physics.Raycast (transform.position, transform.forward, out hit, maxDistance, rayMask))
			depthOfFieldObject.position = hit.point;
		else
			depthOfFieldObject.position = transform.position + transform.forward * maxDistance * thing;
			
	}
}
