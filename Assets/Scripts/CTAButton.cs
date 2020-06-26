using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTAButton : MonoBehaviour
{
    [SerializeField] private PlaygroundFields pgFields;

    [SerializeField] private Image buttonImage;
    [SerializeField] private Text buttonText;

    void Start()
    {
        buttonImage.color = pgFields.ctaButtonColour;
        buttonText.text = pgFields.ctaButtonString;
        buttonText.color = pgFields.ctaButtonTextColour;
    }
    
    public void InstallGame()
    {
        Luna.Unity.Playable.InstallFullGame();
    }
}
