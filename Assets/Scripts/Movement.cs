using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Cube Speed")]
    [SerializeField]  float speed = 10f;

    //the input action map
    private CubeControls cont;

    //the rigid body for the cube
    Rigidbody rb;

    /// <summary>
    /// Use awake to create a new instance of the controls
    /// and grab the rigidbody of the cube
    /// </summary>
    void Awake()
    {
        cont = new CubeControls();

        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Enable the controls
    /// </summary>
    private void OnEnable() { cont.Enable(); }

    /// <summary>
    /// Disable the controls
    /// </summary>
    private void OnDisable() { cont.Disable(); }

    /// <summary>
    /// Use fixed update to move the cube
    /// </summary>
    void FixedUpdate()
    {
        Vector3 moveInput = cont.CubeMap.Movement.ReadValue<Vector3>();

        rb.velocity = moveInput * speed;
    }
}
