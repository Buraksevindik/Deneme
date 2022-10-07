using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    suvari1 clickedObject;
    public List<suvari1> selectedPlayer = new List<suvari1>();
    public List<Gun> gunList;
    public List<suvari1> enemies;
    public List<suvari1> ourSoldiers;
    private void Start()
    {
        //foreach (var soldiers in allSoldiers)
        //{
        //    //Debug.Log("ASD");
        //    soldiers.gameObject.GetComponent<Collider2D>().enabled = false;
        //}
        foreach (var oursoldierss in ourSoldiers)
        {
            oursoldierss.gameObject.GetComponent<Collider2D>().enabled = false;
        }
        //foreach (var enemiess in enemies)
        //{
        //    enemiess.gameObject.GetComponent<Collider2D>().enabled = false;
        //}
        clickedObject = GetComponent<suvari1>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if (hit.collider)
            {
                clickedObject = hit.collider.GetComponent<suvari1>();
                if (selectedPlayer.Count == 0)
                {
                    selectedPlayer.Add(clickedObject);
                    foreach (var enemy in enemies)
                    {
                        if ((clickedObject.diceAmount < enemy.diceAmount) || (clickedObject.diceAmount == enemy.diceAmount))
                        {
                            enemy.gameObject.SetActive(false);
                        }
                        else
                        {
                            enemy.gameObject.SetActive(true);
                        }
                    }
                }
                else if (selectedPlayer.Count == 1)
                {
                    Debug.Log("first object " + selectedPlayer[0].diceAmount);
                    /*soldiers[0].SetActive(false);
                    soldiers[1].SetActive(false);
                    soldiers[2].SetActive(false);
                    soldiers[3].SetActive(false);
                    soldiers[4].SetActive(false);*/
                    //Debug.Log("2. ye eklendi");
                    selectedPlayer.Add(clickedObject);
                }
                else if (selectedPlayer.Count == 2)
                {
                    selectedPlayer.Clear();
                }
            }
        }
    }
}