using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clothing", menuName = "Clothing")]
public class Cloths : ScriptableObject
{
    public string clothName;
    public Sprite artwork;
    public int cost;
    
}
