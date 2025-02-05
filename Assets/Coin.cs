
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private PlayerScript Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = FindObjectOfType<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Working");

        if (Player != null)
        {
            Player.AddCoins(1);
            Destroy(this.gameObject);
        }
        

    }
}
