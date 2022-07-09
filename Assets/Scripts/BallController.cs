using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private GameObject splashImg;
    [SerializeField] private float jumpSpeed = 5;
    private Rigidbody rb;
    GameManager gm;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        BallJump();
        GameObject splash = Instantiate(splashImg, transform.position, splashImg.transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        if(materialName=="Unsafe Color (Instance)")
        {
            gm.GameOver();
        }else if(materialName== "Final Ring (Instance)")
        {
            gm.YouWon();
        }

    }

    private void BallJump()
    {
        rb.velocity = Vector3.up * jumpSpeed;
    }
}
