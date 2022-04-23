using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour {

public Card card;

public Text nameText;
public Text descriptionText;

public Image artworkImage;

public Text manaText;
public Text attackText;
public Text healthText;

public TextMeshProUGUI testingText; 
    void Start()
    {
        testingText.text = card.name;

        nameText.text = card.name;
        descriptionText.text = card.description;

        artworkImage.sprite = card.artWork;

        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
    }

}
