using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //Speed Variable
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] Vector3 movement;

    //Character Controller attached to the player game object
    [SerializeField] CharacterController plCharacter;

    // Start is called before the first frame update
    void Start()
    {
        //assign the character controller on game object to the variable
        plCharacter = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Assigning Old Input System Values to Variables.
        //Keeping them in Update to constantly update.
        //Using Time.deltaTime for framerate normalizing
        //and setting speed through moveSpeed variable.
        float zVal = Input.GetAxis("Horizontal") * -moveSpeed * Time.deltaTime;
        float xVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 currentPos = transform.position;
        movement = new Vector3(xVal, 0f, zVal);

        Vector3 postionToLookTowards = movement + currentPos;

        transform.LookAt(postionToLookTowards);

        plCharacter.Move(movement * moveSpeed * Time.deltaTime);
    }
}
