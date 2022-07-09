using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private Transform ball;
    GameManager gm;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (transform.position.y +13.0f> ball.position.y)
        {
            Destroy(gameObject);
            gm.UpScore();
        }
    }
}
