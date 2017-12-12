using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWindActive : MonoBehaviour
{
	[SerializeField] private GameObject targetObject;

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
			targetObject.SetActive (true);
		}
	}
}
