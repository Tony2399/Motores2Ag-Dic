using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    private int isWalkingHash;
    private int isRunningHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("IsWalking");
        isRunningHash = Animator.StringToHash("IsRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey(KeyCode.W);


        bool isRunning = animator.GetBool(isRunningHash);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if (forwardPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (!forwardPressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }
        if ((forwardPressed && runPressed) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }
        if ((!forwardPressed || !runPressed) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }

    }
}
