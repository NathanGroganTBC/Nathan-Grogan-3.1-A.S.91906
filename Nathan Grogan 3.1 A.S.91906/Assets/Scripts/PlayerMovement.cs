using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("RunHorizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("RunVertical", Input.GetAxis("Vertical"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        Vector3 mousePos = Input.mousePosition;
        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 lookAt = mouseScreenPosition; 


        // this code is bad please fix

        float AngleRad = Mathf.Atan2(lookAt.y, lookAt.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        

        transform.position = transform.position + horizontal * Time.deltaTime;
        transform.position = transform.position + vertical * Time.deltaTime;

        Quaternion Quater = Quaternion.Euler(0, 0, AngleDeg);
        Debug.Log(Quater[2] + " " + Quater[3] + " " + (Quaternion.Euler(0, 0, AngleDeg)));
        if (Quater[2] < 0 & Quater[3] < 0)
        {
            Debug.Log("buhg");
        }

    }
}
