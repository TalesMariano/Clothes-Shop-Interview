using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDressCharacter : MonoBehaviour
{
    public GameObject player;

    //public CharacterSpriteAnimation spriteAnimationPrefab;

    public ItemVisual itemVisual;

    [ContextMenu("Test")]
    void SpawnClothing()
    {
        var newClothing = Instantiate(itemVisual.itemPrefab, player.transform).GetComponent<CharacterSpriteAnimation>();

        newClothing.character = player.GetComponent<PlayerMovement>();
    }

    void ApplyVisual(CharacterSpriteAnimation anim)
    {
        
    }
}
