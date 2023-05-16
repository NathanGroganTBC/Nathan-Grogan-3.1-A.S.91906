using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    string lookDirection = null;
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("RunHorizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("RunVertical", Input.GetAxis("Vertical"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        Vector3 mousePos = Input.mousePosition;
        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetAxis("Horizontal") < 0 | Input.GetAxis("Vertical") < 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                lookDirection = "Left";
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                lookDirection = "Down";
            }
        }
        else if (Input.GetAxis("Horizontal") > 0 | Input.GetAxis("Vertical") > 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                lookDirection = "Right";
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                lookDirection = "Up";
            }
        }
        

        transform.position = transform.position + horizontal * Time.deltaTime;
        transform.position = transform.position + vertical * Time.deltaTime;


        Debug.Log(lookDirection);


    }
}
