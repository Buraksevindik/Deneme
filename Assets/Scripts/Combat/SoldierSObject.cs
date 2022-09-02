using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Soldiers")]

public class SoldierSObject : ScriptableObject
{
    [SerializeField] private Shield shield;
    [SerializeField] private Gun gun;
    public Shield Shield => shield;
    public Gun Gun => gun;
}