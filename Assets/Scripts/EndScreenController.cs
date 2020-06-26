using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class EndScreenController : MonoBehaviour
{

    [SerializeField] private PlaygroundFields pgFields;
    
    [SerializeField] private GameObject ctaButton;

    [SerializeField] private Image ctaImage;
    [SerializeField] private Text ctaText;

    bool endScreenActive;

    private bool endGame;

    void Awake()
    {
        ctaImage.color = pgFields.endCtaButtonColour;
        ctaText.text = pgFields.endCtaButtonString;
        ctaText.color = pgFields.endCtaButtonTextColour;
    }
    
    public void Start()
    {
        ctaButton.SetActive(false);
        endScreenActive = true;
        if (pgFields.Aggro)
        {
            EndGame();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EndGame();
        }
    }
    
    void EndGame()
    {
        Luna.Unity.Playable.InstallFullGame();
        if (!endGame)
        {
            Luna.Unity.LifeCycle.GameEnded();
            endGame = true;
        }
    }

    
}
