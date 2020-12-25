using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CamControl : MonoBehaviour
{
    PlayerControl controls;

    Vector3 move;

    Vector3 rotate;

    float forwardMotion;


    private void Awake()
    {
        controls = new PlayerControl();

        controls.cam.Move.performed += ctx => move = ctx.ReadValue<Vector2>();

        controls.cam.Move.canceled += ctx => move = Vector2.zero;

        controls.cam.Front.performed += ctx => { forwardMotion = ctx.ReadValue<float>(); };
        controls.cam.Front.canceled += ctx => { forwardMotion = forwardMotion > 0.0f ? 0.0f : forwardMotion; };
        controls.cam.Back.performed += ctx => { forwardMotion = -ctx.ReadValue<float>(); };
        controls.cam.Back.canceled += ctx => { forwardMotion = forwardMotion < 0.0f ? 0.0f : forwardMotion; };

        controls.cam.Look.performed += ctx => rotate = ctx.ReadValue<Vector2>();

        controls.cam.Look.canceled += ctx => rotate = Vector2.zero;

    }

    void Update()
    {
        Vector3 m = new Vector3(-move.x, move.y, forwardMotion) * 5f * Time.deltaTime;
        transform.Translate(m, Space.Self);


        Vector3 r = new Vector3(-rotate.y, -rotate.x, 0.0f) * 50f * Time.deltaTime;
        transform.Rotate(r, Space.Self);

    }

    void OnEnable()
    {
        controls.cam.Enable();
    }

    private void OnDisable()
    {
        controls.cam.Disable();

    }

}
