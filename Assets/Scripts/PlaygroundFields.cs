using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FingerType { BLACK_FINGER, CARTOON_FINGER, CARTOON_FINGER_2, HAND_6, IS_HAND_POINT, LADY_FINGER_1, WHITE_FINGER}

[CreateAssetMenu(fileName = "PlaygroundFields", menuName = "PlaygroundFields")]
public class PlaygroundFields : ScriptableObject
{
    [SerializeField] private Sprite[] fingerSprites;

    [LunaPlaygroundField("Aggro Mode",0,"Aggro")]
    public bool Aggro;

    [LunaPlaygroundField("Stop 1",0,"Stops")]
    public float stop0;

    [LunaPlaygroundField("tutorial Text", 1, "Tutorial")]
    public string tutorialString;
    [LunaPlaygroundField("tutorial Text Colour", 2, "Tutorial")]
    public Color tutorialTextColour;
    [LunaPlaygroundField("tutorial Text Y Position", 3, "Tutorial")]
    public float tutorialYPos;

    [LunaPlaygroundField("CTA button Colour", 0, "CTA")]
    public Color ctaButtonColour;
    [LunaPlaygroundField("CTA button Text", 1, "CTA")]
    public string ctaButtonString;
    [LunaPlaygroundField("CTA button Text Colour", 2, "CTA")]
    public Color ctaButtonTextColour;

    [LunaPlaygroundField("End CTA button Colour", 0, "End CTA")]
    public Color endCtaButtonColour;
    [LunaPlaygroundField("End CTA button Text", 1, "End CTA")]
    public string endCtaButtonString;
    [LunaPlaygroundField("End CTA button Text Colour", 2, "End CTA")]
    public Color endCtaButtonTextColour;

    [LunaPlaygroundField("Pickup Message Text Color", 0, "Message Text")]
    public Color messageColor;
    [LunaPlaygroundField("Pickup Message Text", 1, "Message Text")]
    public string messageText;

    [LunaPlaygroundField("Profile Pic Index", 0, "Profile Pic")]
    public int profileIndex;

    [LunaPlaygroundField("Finger Type", 0, "CTA Finger")]
    [SerializeField] private FingerType fingerType;
    [LunaPlaygroundField("Finger Position", 2, "CTA Finger")]
    public Vector3 fingerPosition;
    [LunaPlaygroundField("Finger Rotation", 1, "CTA Finger")]
    public float fingerRotation;
    [LunaPlaygroundField("Finger Scale", 2, "CTA Finger")]
    public float fingerScale = 1f;

    public Sprite fingerSprite { get { return fingerSprites[(int)fingerType]; } }

}
