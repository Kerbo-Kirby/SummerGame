using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Cinemachine;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{

    public CharacterController player;
    public float jump = 1;
    public float gravity = 5;
    public Vector3 velocity ;
 
    public float speed;
        // Start is called before the first frame update
        void Start()
        {
          
            
           // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
          //  player.Move(move * Time.deltaTime * speed);

         
          player = GetComponent<CharacterController>();
        }

// Update is called once per frame
    void Update()
    {
        

        var hAxis = Input.GetAxis("Horizontal");

        var vAxis = Input.GetAxis("Vertical");
        
        
        velocity.y -= gravity * Time.deltaTime;

        player.Move(velocity * Time.deltaTime);
    
      

       
        if (player.isGrounded && jump == 0)

            velocity.y = 0;

        if (Input.GetButtonDown("Jump") && 2 >= jump)

            
            
            velocity.y = jump;
        jump = 2;

      ////  if (velocity.y >= 2)
         ////   jump = 0;

         ////p//layer.transform.rotation =  


        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        player.Move(move * Time.deltaTime * speed);
        
    }

    
}
