using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class suvari1 : MonoBehaviour
{
    //Gun gun;
    //Shield shield;
    //public
    GameObject clickedEnemy;
    SelectManager selectManager;
    public SoldierSObject soldier;

    //List<Gun> gunList;
    private void Awake()
    {
        selectManager = FindObjectOfType<SelectManager>();
        selectManager.gunList = new List<Gun>();
    }
    //public List<float> a;
    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        clickedEnemy = hit.collider.gameObject;
        //Debug.Log(soldier.Gun.attackType);
        if (selectManager.selectedPlayer.Count == 0)
        {
            Debug.Log("birinci t�klan��");
            selectManager.gunList.Add(soldier.Gun);
            //Debug.Log("birinci oyuncunun k�l�c� se�ildi");
        }
        else if (selectManager.selectedPlayer.Count == 1)
        {
            Debug.Log("ikinci t�klan��");

            Debug.Log(selectManager.gunList[0]);
            /*  Debug.Log("checkAnti");*/

            checkAnti();
            selectManager.gunList.Clear();
            //Debug.Log("ikinci oyuncunun kalkan� se�ildi");
        }
    }
    public void checkAnti()
    {

        if (soldier.Shield.advantageList.Contains(selectManager.gunList[0]))
        {
            Debug.Log("KALKAN S�LAHA ANT�");
        }
        else if (soldier.Shield.disAdvantageList.Contains(selectManager.gunList[0]))
        {
            Debug.Log("S�LAH KALKANA ANT�");
        }
        else
        {
            Debug.Log("�K�S� DE ANT� DE��L");
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