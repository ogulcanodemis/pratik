using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{





    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome the game");
        Debug.Log("Move your player with wasd or arrow keys canýsý");
        Debug.Log("Dont hit the walls");

    }
    void MovePlayer ()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed * -1;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * -1;
        transform.Translate(xValue,0f,zValue);
    }
}
