using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card/Minion")]
public class Card : ScriptableObject {

    public new string name { get; set; }
    public string description { get; set; } 

    public Sprite artWork { get; set; }

    public int manaCost { get; set; }
    public int attack { get; set; }
    public int health { get; set; }
}
