using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //Speed Variable
   [SerializeField] float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

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

        transform.Translate(xVal, 0, zVal);

    }
}
