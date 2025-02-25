using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRInputHandler : MonoBehaviour
{
    public VRCharacterController character; // Reference to character controller
    public XRDirectInteractor leftHand; // Left VR hand/controller
    public XRDirectInteractor rightHand; // Right VR hand/controller

    void Update()
    {
        // Detect movement from either hand to trigger walk
        bool isMoving = (leftHand != null && leftHand.isSelectActive) ||
                       (rightHand != null && rightHand.isSelectActive);
        if (character != null) character.animator.SetBool("IsWalking", isMoving);

        // Trigger wave on right-hand grip (customize for specific VR input)
        if (rightHand != null && Input.GetKeyDown(KeyCode.G)) // Replace with VR input
        {
            character.animator.SetTrigger("Wave");
        }
    }
}
