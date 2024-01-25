using UnityEngine;

public class Anim_Bird : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Set the 'touched' bool to true when a collision is detected
        animator.SetBool("touched", true);
        Debug.Log("IVE BEEN TOUCHED");
    }
}
