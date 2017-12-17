using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField]
    private GameObject checkpointStart;
    [SerializeField]
    private GameObject checkpoint1;
    [SerializeField]
    private GameObject checkpoint2;
    [SerializeField]
    private GameObject lever1;
    [SerializeField]
    private GameObject lever2;

    private bool checkpoint1Enabled = false;
    private bool checkpoint2Enabled = false;

    private Animator lever1Animator;
    private Animator lever2Animator;

    void Start ()
    {
        lever1Animator = lever1.GetComponent<Animator>();
        lever2Animator = lever2.GetComponent<Animator>();
    }

    void Update ()
    {
        if (lever1Animator.GetBool("isDoorOpen") == true)
        {
            checkpoint1Enabled = true;
        }
        else if (lever1Animator.GetBool("isDoorOpen") == false)
        {
            checkpoint1Enabled = false;
        }

        if (lever2Animator.GetBool("isDoorOpen") == true)
        {
            checkpoint2Enabled = true;
        }
        else if (lever2Animator.GetBool("isDoorOpen") == false)
        {
            checkpoint2Enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpoint1Enabled && !checkpoint2Enabled)
            {
                other.transform.position = checkpoint1.transform.position;
                lever1Animator.SetBool("isDoorOpen", false);
                lever2Animator.SetBool("isDoorOpen", false);
                lever1.GetComponent<Door>().isOpen = false;
                lever2.GetComponent<Door>().isOpen = false;
            }
            else if (checkpoint2Enabled)
            {
                other.transform.position = checkpoint2.transform.position;
                lever1Animator.SetBool("isDoorOpen", true);
                lever2Animator.SetBool("isDoorOpen", false);
                lever1.GetComponent<Door>().isOpen = true;
                lever2.GetComponent<Door>().isOpen = false;
            }
            else
            {
                other.transform.position = checkpointStart.transform.position;
                lever1Animator.SetBool("isDoorOpen", false);
                lever2Animator.SetBool("isDoorOpen", false);
                lever1.GetComponent<Door>().isOpen = false;
                lever2.GetComponent<Door>().isOpen = false;
            }
        }
    }
}
