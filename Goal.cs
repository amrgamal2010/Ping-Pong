using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal1;

    private void OnTriggerEnter2D(Collider2D collition)
    {
        if (collition.gameObject.CompareTag("ball"))
        {
            if (!isPlayer1Goal1)
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("Gamemanager").GetComponent<Gamemanager>().Player1Scored();
            }
            else
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("Gamemanager").GetComponent<Gamemanager>().Player2Scored();
            }
        }

    }
    
}
