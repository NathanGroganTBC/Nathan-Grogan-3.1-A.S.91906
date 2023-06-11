using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public ExitDoorScript won;

    string lookDirection = null;
    int lookAxis = 2;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("RunHorizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("RunVertical", Input.GetAxis("Vertical"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);

        if (Input.GetAxis("Horizontal") < 0 | Input.GetAxis("Vertical") < 0 | Input.GetAxis("Horizontal") > 0 | Input.GetAxis("Vertical") > 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                lookDirection = "Left";
                lookAxis = 3;
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                lookDirection = "Down";
                lookAxis = 2;
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                lookDirection = "Right";
                lookAxis = 4;
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                lookDirection = "Up";
                lookAxis = 1;
            }
        }

        if (!won.HasWonGame())
        {
            transform.position = transform.position + horizontal * Time.deltaTime;
            transform.position = transform.position + vertical * Time.deltaTime;
        }

        if (Input.GetAxis("Horizontal") < 0.01f && Input.GetAxis("Horizontal") > -0.01f && Input.GetAxis("Vertical") < 0.01f && Input.GetAxis("Vertical") > -0.01f)
        {
            animator.SetInteger("IsIdle", 1);
        }
        else
        {
            animator.SetInteger("IsIdle", 0);
        }
        animator.SetInteger("LookDirection", lookAxis);
    }
}
