using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlatforms : MonoBehaviour
{
    [SerializeField]
    private GameObject platformSet;

    private Animator platformAnimator;
    private Animator leverAnimator;

    private void Start()
    {
        platformAnimator = platformSet.GetComponent<Animator>();
        leverAnimator = GetComponent<Animator>();
    }
    void Update ()
    {
        if (leverAnimator.GetBool("isDoorOpen") == true)
        {
            platformAnimator.SetBool("isActive", true);
        }
        else if (leverAnimator.GetBool("isDoorOpen") == false)
        {
            platformAnimator.SetBool("isActive", false);
        }
	}
}
