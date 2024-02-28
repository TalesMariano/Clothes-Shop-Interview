using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpriteAnimation : MonoBehaviour
{

    public PlayerMovement character;
    private Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = character.Direction;
        var movement = character.Movement;

        anim.SetFloat("Dir H", direction.x);
        anim.SetFloat("Dir V", direction.y);

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }
}
