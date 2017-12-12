using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWind : MonoBehaviour
{
	[SerializeField] private GameObject targetObject;

	private Animator animator;

	private void Awake()
	{
		animator = GetComponent<Animator> ();
	}

	private void Update ()
	{
		if (animator.GetBool ("isDoorOpensd") == true)
		{
			targetObject.SetActive (false);
		}
	}
}
