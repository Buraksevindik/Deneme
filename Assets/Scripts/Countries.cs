using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Countrys", order = 1)]
public class Countries : ScriptableObject
{
    [SerializeField] private int gold;
    [SerializeField] private int food;
    [SerializeField] private int wood;
    [SerializeField] private int metal;
    [SerializeField] private int stone;

    public int Gold => gold;
    public int Food => food;
    public int Wood => wood;
    public int Metal => metal;
    public int Stone => stone;
}