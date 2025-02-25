using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRCharacterController : MonoBehaviour
{
    public Animator animator; // Animator component for character animations
    public XRDirectInteractor handInteractor; // VR hand/controller input

    void Update()
    {
        // Check if hand/controller is active (e.g., moving forward in VR)
        if (handInteractor != null && handInteractor.isSelectActive)
        {
            animator.SetBool("IsWalking", true); // Trigger walk animation
        }
        else
        {
            animator.SetBool("IsWalking", false); // Return to idle
        }

        // Trigger wave animation on secondary input (e.g., trigger button)
        if (Input.GetKeyDown(KeyCode.Space)) // Customize for VR input
        {
            animator.SetTrigger("Wave"); // One-time wave gesture
        }
    }
}
