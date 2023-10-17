using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //Animator anim;
    private Rigidbody rb;
    public Transform cam;

    public float speed = 30f;
    public float turnSmoothTime =0.1f;
    private float turnSmoothVelocity;
    public static bool frozen = false;

    void Start(){
        frozen = false;
        rb = gameObject.GetComponent<Rigidbody>();

        cam = GameObject.FindWithTag("MainCamera").GetComponent<Transform>();
    }

    void Update () {
        float horiz = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");

        Vector3 direct = new Vector3(horiz, 0f, vert).normalized;
        if (frozen) {
            direct = new Vector3(0f, 0f, 0f).normalized;
        }
        

        if (direct.magnitude >= 0.1f) {
            float targetAngle = Mathf.Atan2(direct.x, direct.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.MovePosition(transform.position + moveDir * speed * Time.deltaTime);
        }
    }
}
