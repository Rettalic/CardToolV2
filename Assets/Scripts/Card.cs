using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;

    public Sprite backgroundArt;
    public Sprite characterArt;

    public Sprite costSprite;
    public Sprite attackSprite;
    public Sprite healthSprite;
    
    public int cost;
    public int attack;
    public int health;
}
