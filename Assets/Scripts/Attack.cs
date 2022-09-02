using UnityEngine;

public class Attack : MonoBehaviour
{
    Player player;
    Player2 player2;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        player2 = FindObjectOfType<Player2>();
    }
    public void Attackk()
    {
        if (player.player1)
        {
            Debug.Log("player1");
            player.Attack();
        }
        else if (player2.player2)
        {
            Debug.Log("player2");
            player2.Attack();
        }
    }
}
