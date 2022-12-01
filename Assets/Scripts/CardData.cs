using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "CardGame/Card")]
public class CardData : ScriptableObject
{
    public enum DamageType
    { 
        Fire,
        Ice,
        Both,
        Destruct
    }

    public string cardTitle;
    public string description;

    public int cost;
    public int damage;
    public int numberInDeck;

    public DamageType damageType;
    public Sprite cardImage;
    public Sprite frameImage;    

    public bool isDefenseCard = false;
    public bool isMirrorCard = false;
    public bool isMultiCard = false;
    public bool isDestructCard = false;
}
