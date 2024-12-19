using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float HorizontalMovementSpeed = 8;
    [SerializeField] float VerticalMovementSpeed = 10;



    void Update()
    {
        Move();
    }

    private void Move()
    {
        float HorizontalMovement = Input.GetAxisRaw("Horizontal");
        float VerticalMovement = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(HorizontalMovement * HorizontalMovementSpeed, VerticalMovement * VerticalMovementSpeed, 0) * Time.deltaTime;


    }
}
