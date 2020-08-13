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
    [SerializeField] private Text messageText;
    [SerializeField] private Image profileImage;
    [SerializeField] private List<Sprite> profiles;
    [SerializeField] private int profileIndex;

    bool endScreenActive;

    private bool endGame;

    void Awake()
    {
        ctaImage.color = pgFields.endCtaButtonColour;
        ctaText.text = pgFields.endCtaButtonString;
        ctaText.color = pgFields.endCtaButtonTextColour;
        messageText.color = pgFields.messageColor;
        messageText.text = pgFields.messageText;
        profileIndex = pgFields.profileIndex;

        if (profileIndex < 0 || profileIndex >= profiles.Count)
            profileIndex = 0;

        profileImage.sprite = profiles[profileIndex];
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
