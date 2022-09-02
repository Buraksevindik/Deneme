using TMPro;
using UnityEngine;

public class CountryDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] TextMeshProUGUI txt1;
    public Countries countries;
    Player checkActivePlayer;
    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        countries = hit.collider.GetComponent<CountryDisplay>().countries;
        if (hit.collider != null)
        {
            txt.text = countries.name;
            txt1.text = (countries.Gold, countries.Food, countries.Wood, countries.Metal, countries.Stone).ToString();
            //hit.collider.GetComponent<CountryDisplay>().countries.gold--;
        }
    }
}
