using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateControl : MonoBehaviour
{
    private Animator animator;
    private float velocity;
    private int velocityHash;
    public float acceleration = 1.0f;
    public float deceleration = .5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        velocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKeyUp(KeyCode.W);
        bool runPressed = Input.GetKeyUp(KeyCode.LeftShift);

        if (forwardPressed && velocity < 1.0f) { 
            velocity += Time.deltaTime * acceleration;
        }
        if (!forwardPressed && velocity > 0.0f) { 
            velocity -= Time.deltaTime * deceleration;
        }

        if (!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        animator.SetFloat(velocityHash, velocity);
    }
}
