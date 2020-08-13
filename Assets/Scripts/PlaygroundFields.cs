using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlaygroundFields", menuName = "PlaygroundFields")]
public class PlaygroundFields : ScriptableObject
{

    [LunaPlaygroundField("Aggro Mode",0,"Aggro")]
    public bool Aggro;

    [LunaPlaygroundField("Stop 1",0,"Stops")]
    public float stop0;

    [LunaPlaygroundField("tutorial Text", 1, "Tutorial")]
    public string tutorialString;
    [LunaPlaygroundField("tutorial Text Colour", 2, "Tutorial")]
    public Color tutorialTextColour;

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


}
