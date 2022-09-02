using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] private int gold;
    [SerializeField] private int food;
    [SerializeField] private int wood;
    [SerializeField] private int metal;
    [SerializeField] private int stone;
    Player2 player2;
    public bool player1 = false;

    private void Awake()
    {
        player2 = FindObjectOfType<Player2>();
    }
    private Countries countries;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider!=null)
            {
                countries = hit.collider.GetComponent<CountryDisplay>().countries;
            }
        }
    }
    public void Attack()
    {
        //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        gold += countries.Gold;
        food += countries.Food;
        wood += countries.Wood;
        metal += countries.Metal;
        stone += countries.Stone;
        txt.text = ((((gold, food, wood, metal, stone)))).ToString();
    }
    public void ChangePlayer()
    {
        Debug.Log("player1");
        player1 = true;
        player2.player2=false;
    }
}