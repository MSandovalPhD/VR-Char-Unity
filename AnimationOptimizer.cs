using UnityEngine;

public class AnimationOptimizer : MonoBehaviour
{
    public Animator animator; // Animator to optimize
    private float lastUpdateTime; // Track update frequency
    private const float updateInterval = 0.1f; // Update every 0.1 seconds

    void Update()
    {       
        if (Time.time - lastUpdateTime >= updateInterval)
        {
            OptimizeAnimations();
            lastUpdateTime = Time.time;
        }
    }

    void OptimizeAnimations()
    {        
        if (animator != null) animator.Update(0);        
    }
}
