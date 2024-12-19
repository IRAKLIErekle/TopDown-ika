using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    [SerializeField] private float speed = 5;
    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(horizontalMovement * Time.deltaTime * speed, 0, 0);

        Debug.Log(horizontalMovement);
    }
}
