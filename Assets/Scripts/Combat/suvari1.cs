using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class suvari1 : MonoBehaviour
{
    bool a;
    public GameObject dice1,dice2;
    GameObject clickedEnemy;
    SelectManager selectManager;
    public SoldierSObject soldier;
    public int diceAmount;
    //List<Gun> gunList;
    private void Awake()
    {
        selectManager = FindObjectOfType<SelectManager>();
        selectManager.gunList = new List<Gun>();
        //dice2 = dice1.GetComponent<Dice>().go;
    }
    private void OnMouseDown()
    {
        //Debug.Log(selectManager.selectedPlayer.Count);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        clickedEnemy = hit.collider.gameObject;
        //**********************************************************************************************************************************************************
        //TIKLANAN OBJELER L�STEYE D��ER SCRIPTTE EKLEND��� ���N BURADAN D�REKT OLARAK �EK�LM�YOR(MUHTEMELEN BU ��LEM� YAPTIKTAN SONRA L�STEYE EKL�YOR VE BURADA L�STE BO� G�R�N�YOR.) 
        //foreach (var item in selectManager.ourSoldiers)
        //{

        //} //�stteki a��klama buradaki if in i�indeki selectManager.selectedPlayer[1]==item i�in
        if (selectManager.selectedPlayer.Count == 0  /*|| selectManager.selectedPlayer[1] == item*/)
        {
            Debug.Log("a");
            selectManager.gunList.Add(soldier.Gun);
            foreach (var enemy in selectManager.enemies)
            {
                if (enemy)
                {
                    enemy.gameObject.GetComponent<Collider2D>().enabled = true;
                }
            }
        }
        else if (selectManager.selectedPlayer.Count == 1 /*&& selectManager.selectedPlayer[1] != item*/)
        {
            Debug.Log("b");
            selectManager.selectedPlayer.Add(this);
            a = true;
            for (int i = 0; i < selectManager.ourSoldiers.Count; i++)
            {
                if (selectManager.selectedPlayer[1] == selectManager.ourSoldiers[i])
                {
                    selectManager.selectedPlayer.Insert(0, selectManager.selectedPlayer[0]);
                    selectManager.selectedPlayer.Remove(selectManager.selectedPlayer[0]);
                    a = false;
                }
            }
            if (a)
            {
                CheckAnti();
                Attackk();
                foreach (var enemy in selectManager.enemies)
                {
                    if (enemy)
                    {
                        enemy.gameObject.GetComponent<Collider2D>().enabled = false;
                    }
                }
                selectManager.gunList.Clear();
            }
        }
        else
        {
            Debug.Log("c");
            selectManager.selectedPlayer.Clear();
            //selectManager.selectedPlayer.Add(this);
            selectManager.gunList.Add(soldier.Gun);
            //Debug.Log(selectManager.selectedPlayer.Count);
            foreach (var enemy in selectManager.enemies)
            {
                if (enemy)
                {
                    enemy.gameObject.GetComponent<Collider2D>().enabled = true;
                }
            }
        }
    }
    public void BuyuklukHesapla()
    {
        foreach (var enemy in selectManager.enemies)
        {
            if ((selectManager.selectedPlayer[0].diceAmount > enemy.diceAmount) || (selectManager.selectedPlayer[0].diceAmount==enemy.diceAmount))
            {
                enemy.gameObject.GetComponent<Collider2D>().enabled = false;
            }
        }
    }
    public void Attackk()
    {
        Destroy(this.gameObject);
    }
    public void CheckAnti()
    {
        if (soldier.Shield.advantageList.Contains(selectManager.gunList[0]))
        {
            diceAmount++;
        }
        else if (soldier.Shield.disAdvantageList.Contains(selectManager.gunList[0]))
        {
            diceAmount--;
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
        //        Debug.Log("ikisi de anti de�il");
        //    }
        //}
        //else if (soldier.Gun.attackType == Gun.attackTypes.b)
        //{
        //    if (soldier.Shield.shieldType == Shield.shieldTypes.a)
        //    {
        //        Debug.Log("ikisi de anti de�il");
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