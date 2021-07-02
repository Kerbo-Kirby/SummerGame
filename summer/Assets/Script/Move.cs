using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Move : MonoBehaviour
{

    public CharacterController player;
    public float jump = 1;
    public float gravity = 5;
    public Vector3 velocity ;
    public int hori;
    public int vert;
    public int click;

        // Start is called before the first frame update
        void Start()
        {
            click = 5;
        }

// Update is called once per frame
    void Update()
    {
        player = GetComponent<CharacterController>();

          
        velocity.y -= gravity * Time.deltaTime;

        player.Move(velocity * Time.deltaTime);
        
        
        if (player.isGrounded && jump ==0)

            velocity.y = 0;

        if (Input.GetButtonDown("Jump") )
            
            
            velocity.y = jump;

        jump = click;


        //if (Input.GetKey(KeyCode.RightArrow))

        //  ;




    }

    
}
