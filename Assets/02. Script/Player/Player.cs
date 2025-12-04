using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }

    #region Class
    private Rigidbody rb;
    private PlayerControll _controll;
    #endregion
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        _controll = new PlayerControll(this);
    }

    private void OnEnable()
    {
        _controll.OnEnable();
    }

    private void OnDisable()
    {
        _controll.OnDisable();
    }

    public void SetMoveInput(Vector2 vec)
    {
        MoveInput = vec;
    }

    private void FixedUpdate()
    {
        float currentY = rb.velocity.y;
        Vector3 targetVelocity = new Vector3(MoveInput.x * 5, currentY, MoveInput.y * 5);
        rb.velocity = targetVelocity;
    }
}
