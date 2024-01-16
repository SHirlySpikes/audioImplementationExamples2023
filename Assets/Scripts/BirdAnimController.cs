using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Set the 'touched' bool to true when a collision is detected
        animator.SetBool("touched", true);
    }


}
