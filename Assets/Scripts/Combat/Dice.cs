using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Dice : MonoBehaviour
{
    
    public GameObject secondDice;
    public suvari1 suvari1;
    SelectManager selectManager;
    public SoldierSObject soldier;
    int randomDiceSide = 0;
    public int finalSide = 0;
    public GameObject go;
    string a;

    private Sprite[] diceSides;

    private SpriteRenderer rend;
    Vector3 vector;

    private void Start()
    {
        selectManager = FindObjectOfType<SelectManager>();
        vector = gameObject.transform.position;
        string a = this.gameObject.name;
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
    }
    //private void OnMouseDown()
    //{
    //    LoopRollTheDice();
    //}
    public void LoopRollTheDice()
    {
        foreach (var ourSoldiers in selectManager.ourSoldiers)
        {
            ourSoldiers.gameObject.GetComponent<Collider2D>().enabled=true;
        }
        for (int i = 0; i < soldier.Gun.DiceAmount; i++)
        {
            if (i == 0)
            {
                RollTheDice(this.gameObject);
                suvari1.diceAmount = (this.gameObject.GetComponent<Dice>().finalSide + secondDice.GetComponent<Dice>().finalSide);
            }
            else if (i == 1)
            {
                go.SetActive(true);
                RollTheDice(go);
                suvari1.diceAmount = (this.gameObject.GetComponent<Dice>().finalSide + secondDice.GetComponent<Dice>().finalSide);
            }
        }
    }
    private void RollTheDice(GameObject go)
    {
        randomDiceSide = Random.Range(0, soldier.Gun.DiceFace);
        go.GetComponent<SpriteRenderer>().sprite = diceSides[randomDiceSide];
        go.GetComponent<Dice>().finalSide = randomDiceSide + 1;
        Debug.Log(finalSide);
    }
}