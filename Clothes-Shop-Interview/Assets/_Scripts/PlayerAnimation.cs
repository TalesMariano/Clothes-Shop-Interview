using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public PlayerMovement playerMovement;

    public Animator anim1;
    public Animator anim2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = playerMovement.Direction;
        var movement = playerMovement.Movement;


        anim1.SetFloat("Dir H", direction.x);
        anim1.SetFloat("Dir V", direction.y);

        anim2?.SetFloat("Dir H", direction.x);
        anim2?.SetFloat("Dir V", direction.y);


        anim1.SetFloat("Horizontal", movement.x);
        anim1.SetFloat("Vertical", movement.y);
        anim1.SetFloat("Speed", movement.sqrMagnitude);

        anim2?.SetFloat("Horizontal", movement.x);
        anim2?.SetFloat("Vertical", movement.y);
        anim2?.SetFloat("Speed", movement.sqrMagnitude);
    }
}
