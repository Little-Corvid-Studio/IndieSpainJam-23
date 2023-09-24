using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "General/History CutScene")]
public class StoryManager : ScriptableObject
{
    [SerializeField] public StoryScene[] scene;
}

[Serializable]
public class StoryScene 
{
    public Sprite image;
    [TextArea] public string text;
    public bool isLinkedWithPrevious;
    public bool isItalic;
}