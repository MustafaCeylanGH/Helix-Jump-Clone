using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private float distanceMove;
    private Vector3 distance;
    private float followBoundaryY;
    private Vector3 differenceJump = new Vector3(0, 0.2f, 0);

    private void Awake()
    {
        distance = transform.position - ball.transform.position;
    }
    private void Update()
    {
        CameraFollow();
    }
    private void CameraFollow()
    {
        followBoundaryY = transform.position.y - ball.transform.position.y;
        if (followBoundaryY>1.70f)
        {
           transform.position = Vector3.MoveTowards(transform.position, distance + ball.transform.position+ differenceJump, distanceMove);
           
        }
       
    }

}
