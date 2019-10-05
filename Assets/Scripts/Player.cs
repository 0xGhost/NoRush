using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;
    public float rotateSpeed;
    CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal");
        _controller.Move(move * Time.deltaTime * movementSpeed);
        //r.velocity = (transform.forward * movementY + transform.right * movementX )* movementSpeed * Time.deltaTime;

        float mouseX = Input.GetAxis("Mouse X");
        

        //float mouseY = Input.GetAxis("Mouse Y");
        //Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * mouseX * Time.deltaTime);
        //r.MoveRotation(deltaRotation * r.rotation);
        transform.Rotate(0, mouseX * rotateSpeed * Time.deltaTime, 0);
        //r.AddForce(new Vector3(movementX, 0, movementY) * movementSpeed * Time.deltaTime);
        //this.gameObject.transform.Translate(new Vector3(movementX , 0, movementY) * movementSpeed * Time.deltaTime);
    }
}
