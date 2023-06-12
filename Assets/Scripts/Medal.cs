using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    public Sprite metalMedal, bronzeMedal, silverMedal, goldMedal;
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        int gameScore = GameManager.gameScore;
    }

    // Update is called once per frame
    void Update()
    {
        img = GetComponent<Image>();

        int gameScore = GameManager.gameScore;

        if (gameScore > 0 && gameScore <= 15)
        {
            img.sprite = metalMedal;
        }
        else if (gameScore > 15 && gameScore <= 35)
        {
            img.sprite = bronzeMedal;
        }
        else if (gameScore > 35 && gameScore <= 100)
        {
            img.sprite = silverMedal;
        }
        else if (gameScore > 100)
        {
            img.sprite = goldMedal;
        }
    }
}
