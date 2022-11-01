using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image backGroundImage;
    public Image characterImage;

    public Image costImage;
    public Image attackImage;
    public Image healthImage;

    public TextMeshProUGUI cost;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI health;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text          = card.name;
        descriptionText.text   = card.description;

        backGroundImage.sprite = card.backgroundArt;
        characterImage.sprite  = card.backgroundArt;

        costImage.sprite       = card.costSprite;
        attackImage.sprite     = card.attackSprite;
        healthImage.sprite     = card.healthSprite;

        cost.text = card.cost.ToString();
        attack.text = card.attack.ToString();
        health.text = card.health.ToString();
    }


}
