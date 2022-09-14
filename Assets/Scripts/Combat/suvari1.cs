using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class suvari1 : MonoBehaviour
{
    public GameObject dice1,dice2;
    GameObject clickedEnemy;
    SelectManager selectManager;
    public SoldierSObject soldier;
    int diceAmount;

    //List<Gun> gunList;
    private void Awake()
    {
        selectManager = FindObjectOfType<SelectManager>();
        selectManager.gunList = new List<Gun>();
        //dice2 = dice1.GetComponent<Dice>().go;
    }
    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        clickedEnemy = hit.collider.gameObject;
        //Debug.Log(soldier.Gun.attackType);
        if (selectManager.selectedPlayer.Count == 0)
        {
            //Debug.Log("EKLENDÝ");
            diceAmount = (dice1.GetComponent<Dice>().finalSide + dice2.GetComponent<Dice>().finalSide);
            Debug.Log(diceAmount);
            selectManager.gunList.Add(soldier.Gun);
        }
        else if (selectManager.selectedPlayer.Count == 1)
        {
            diceAmount = (dice1.GetComponent<Dice>().finalSide + dice2.GetComponent<Dice>().finalSide);
            //Debug.Log(diceAmount);
            //Debug.Log(selectManager.gunList[0]);
            checkAnti();
            selectManager.gunList.Clear();
        }
    }
    public void checkAnti()
    {
        if (soldier.Shield.advantageList.Contains(selectManager.gunList[0]))
        {
            Debug.Log("KALKAN SÝLAHA ANTÝ");
        }
        else if (soldier.Shield.disAdvantageList.Contains(selectManager.gunList[0]))
        {
            Debug.Log("SÝLAH KALKANA ANTÝ");
        }
        else
        {
            Debug.Log("ÝKÝSÝ DE ANTÝ DEÐÝL");
        }
        #region comments
        //for (int i = 0; i < gunList.Count; i++)
        //{
        //    Debug.Log(gunList[i]);
        //}
        //if (soldier.Gun.attackType == Gun.attackTypes.a)
        //{
        //    if (soldier.Shield.shieldType == Shield.shieldTypes.a)
        //    {
        //        Debug.Log("silah kalkana anti");
        //    }
        //    else if (soldier.Shield.shieldType == Shield.shieldTypes.b)
        //    {
        //        Debug.Log("kalkan silaha anti");
        //    }
        //    else if (soldier.Shield.shieldType == Shield.shieldTypes.c)
        //    {
        //        Debug.Log("ikisi de anti deðil");
        //    }
        //}
        //else if (soldier.Gun.attackType == Gun.attackTypes.b)
        //{
        //    if (soldier.Shield.shieldType == Shield.shieldTypes.a)
        //    {
        //        Debug.Log("ikisi de anti deðil");
        //    }
        //    else if (soldier.Shield.shieldType == Shield.shieldTypes.b)
        //    {
        //        Debug.Log("silah kalkana anti");
        //    }
        //    else if (soldier.Shield.shieldType == Shield.shieldTypes.c)
        //    {
        //        Debug.Log("kalkan silaha anti");
        //    }
        //}
        #endregion
    }
}