using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTriggers : MonoBehaviour
{
    public GameObject ARCamera;
    private ComputeDistance computeDistance;
    private float distance;
    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        computeDistance = ARCamera.GetComponent<ComputeDistance>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null && computeDistance != null)
        {
            distance = computeDistance.Distance;
            AnimatorStateInfo currentState = mAnimator.GetCurrentAnimatorStateInfo(0);

            if (distance >= 0.25f && !currentState.IsName("Idle"))
            {
                mAnimator.SetTrigger("TriggerIdle");
            }
            else if (distance < 0.25f && !currentState.IsName("Attack"))
            {
                mAnimator.SetTrigger("TriggerAttack");
            }
        }
    }
}
