using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    suvari1 clickedCountry;
    public List<suvari1> selectedPlayer = new List<suvari1>();
    public List<Gun> gunList;
    private void Start()
    {
        clickedCountry = GetComponent<suvari1>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            clickedCountry = hit.collider.GetComponent<suvari1>();
            if (selectedPlayer.Count == 0)
            {
                //Debug.Log("1. ye eklendi");
                selectedPlayer.Add(clickedCountry);
            }
            else if (selectedPlayer.Count == 1)
            {
                //Debug.Log("2. ye eklendi");
                selectedPlayer.Add(clickedCountry);
            }
            else if (selectedPlayer.Count == 2)
            {
                selectedPlayer.Clear();
            }
        }
    }
}