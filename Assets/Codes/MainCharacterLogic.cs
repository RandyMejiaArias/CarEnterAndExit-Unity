using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterLogic : MonoBehaviour
{
    public float movementSpeed = 4.0f;
    public float rotateSpeed = 250.0f;
    
    private Animator animator;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotateSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);

        animator.SetFloat("speedX", x);
        animator.SetFloat("speedY", y);
    }
}
