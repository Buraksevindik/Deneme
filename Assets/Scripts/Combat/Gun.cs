using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Gun")]
public class Gun : ScriptableObject
{
    [SerializeField] private int diceFace;
    [SerializeField] private int diceAmount;
    public enum attackTypes
    {
        a,b,c
    }
    public attackTypes attackType;
    public int DiceFace => diceFace;
    public int DiceAmount => diceAmount;
}