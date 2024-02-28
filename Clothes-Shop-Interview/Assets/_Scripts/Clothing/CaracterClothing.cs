using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterClothing : MonoBehaviour
{
    public GameObject currentBodyClothes;
    public GameObject currentHeadClothes;


    public static CaracterClothing Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetClothing(ItemVisual itemVisual)
    {
        if(itemVisual.clothesPart == ClothesPart.Body)
        {
            Destroy(currentBodyClothes);

            currentBodyClothes = Instantiate(itemVisual.itemPrefab, transform);
            var newClothing = currentBodyClothes.GetComponent<CharacterSpriteAnimation>();
            newClothing.character = GetComponent<PlayerMovement>();

        }else if(itemVisual.clothesPart == ClothesPart.Head){
            Destroy(currentHeadClothes);

            currentHeadClothes = Instantiate(itemVisual.itemPrefab, transform);
            var newClothing = currentHeadClothes.GetComponent<CharacterSpriteAnimation>();
            newClothing.character = GetComponent<PlayerMovement>();
        }

        /*
        var newClothing = Instantiate(itemVisual.itemPrefab, transform).GetComponent<CharacterSpriteAnimation>();

        newClothing.character = GetComponent<PlayerMovement>();*/
    }
}
