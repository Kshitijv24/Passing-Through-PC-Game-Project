using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private void Update(){

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * speed * Time.deltaTime, yInput * speed * Time.deltaTime, 0);
    }
}
