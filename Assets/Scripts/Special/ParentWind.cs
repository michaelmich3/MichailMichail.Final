using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentWind : MonoBehaviour
{
	[SerializeField] private GameObject parentTarget;
	[SerializeField] private GameObject childTarget;

	private MeshRenderer meshRenderer;
	private Collider collider;

	private void Awake()
	{
		meshRenderer = GetComponent<MeshRenderer> ();
		collider = GetComponent<Collider> ();
	}

	private void Update ()
	{
		if (meshRenderer.enabled == false && collider.enabled == false)
		{
			childTarget.transform.parent = parentTarget.transform;
		}
	}
}
