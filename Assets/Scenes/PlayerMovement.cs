using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float hozMove, verMove;
    public float speed = 20f;
    float jump = 0f;
    [SerializeField] private AudioSource music;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        music = GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {
        hozMove = Input.GetAxis("Horizontal")*speed;
        verMove = Input.GetAxis("Vertical")*speed;
        if(Input.GetKeyDown(KeyCode.Space)){
            jump = 3f;

        }
    }

    private void FixedUpdate(){
        rb.velocity = new Vector3(hozMove, rb.velocity.y + jump, verMove);
        jump = 0f;
    }
}
