using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float jump = 8.0f;
    public float gravity = 20.0f;
    private Vector3 direction = Vector3.zero;

    private const string state_isWalk = "isWalk";
    private const string state_isJump = "isJump";
    private const string state_isAttack = "isAttack";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            direction = new Vector3(0, 0, Input.GetAxis("Vertical"));
            direction = transform.TransformDirection(direction);
            direction *= speed;

            if (direction.magnitude > 0)
            {
                animator.SetBool(state_isWalk, true);
            }
            else
            {
                animator.SetBool(state_isWalk, false);
            }

            bool isJump = Input.GetButton("Jump");
            animator.SetBool(state_isJump, isJump);

            if (isJump)
            {
                direction.y = jump;
            }

            if (!isJump && Input.GetButton("Fire1"))
            {
                animator.SetBool(state_isAttack, true);
            }
        }

        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);
    }
}
