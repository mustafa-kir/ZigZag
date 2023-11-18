using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private  BallDataTransform ballDataTransform;
    [SerializeField] private float balMoveSpeed;

    private void Update(){
        SetBallMovement();
    }

    private void SetBallMovement(){
        transform.position += ballDataTransform.GetBallDirection() * balMoveSpeed * Time.deltaTime; 
    }
}
