using UnityEngine;
using TMPro;

public class Player2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] private int gold;
    [SerializeField] private int food;
    [SerializeField] private int wood;
    [SerializeField] private int metal;
    [SerializeField] private int stone;
    public bool player2=false;
    Player player1;

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
    private void Awake()
    {
        player1 = FindObjectOfType<Player>();
    }
    public void Attack()
    {
        //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        gold += countries.Gold;
        food += countries.Food;
        wood += countries.Wood;
        metal += countries.Metal;
        stone += countries.Stone;
        txt.text = (gold, food, wood, metal, stone).ToString();
    }
    public void ChangePlayer()
    {
        Debug.Log("player2");
        player1.player1 = false;
        player2 = true;
    }
}