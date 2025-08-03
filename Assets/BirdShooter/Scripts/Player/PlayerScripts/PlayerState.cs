using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public Player player;
    public GameState gameState;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.vidas == 0)
        {
            gameState.ShowGameOverScreen();
            gameObject.SetActive(false);
        }
    }
}
