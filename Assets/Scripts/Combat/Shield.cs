using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Shield")]
public class Shield : ScriptableObject
{
    public List<Gun> advantageList;
    public List<Gun> disAdvantageList;
    public List<Gun> constantList;
    public enum shieldTypes
    {
        a,
        b,
        c 
    }
    public shieldTypes shieldType;
}