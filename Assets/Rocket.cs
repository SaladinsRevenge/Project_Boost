﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
  // Start is called before the first frame update

  Rigidbody rigidBody;
  void Start()
  {
    rigidBody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    ProcessInput();
  }
  private void ProcessInput()
  {
    if (Input.GetKey(KeyCode.Space))
    {
      rigidBody.AddRelativeForce(Vector3.up);
    }
    if (Input.GetKey(KeyCode.A))
    {
      print("Rotate left");
    }
    else if (Input.GetKey(KeyCode.D))
    {
      print("Rotate right");
    }
  }
}
