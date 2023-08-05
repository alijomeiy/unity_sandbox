using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] private GameObject obj;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.ChangeState("Start");
        }
        
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            GameManager.ChangeState("Quit");
        }
    }
}