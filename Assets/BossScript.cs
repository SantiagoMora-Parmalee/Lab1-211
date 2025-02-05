using JetBrains.Annotations;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    [SerializeField] private int MaxCoins;
    [SerializeField] private int CoinAmt;
    [SerializeField] private GameObject Player;
    [SerializeField] private Animator animator;
    [SerializeField] private UIManager uiManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            int PlayerCoins = Player.GetComponent<PlayerScript>().coins;
            CoinAmt += PlayerCoins;
            Player.GetComponent<PlayerScript>().coins -= PlayerCoins;
            uiManager.ChangeScore(Player.GetComponent<PlayerScript>().coins);

            if (CoinsFull())
            {
                animator.SetBool("MoneyIsFull", true);
                animator.SetTrigger("GivesMoney");
                Debug.Log("Thats enough coins");
                Debug.Log(CoinAmt);

            }
            else
            {
                animator.SetBool("MoneyIsFull", false);
                animator.SetTrigger("GivesMoney");
                Debug.Log("Not Enough Coins");
                Debug.Log(CoinAmt);
            }

        }
    }


    bool CoinsFull()
    {
        if (CoinAmt >= MaxCoins)
        {
            return true;
        }

        return false;

    }
}
