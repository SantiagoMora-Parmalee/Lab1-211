using KinematicCharacterController;
using KinematicCharacterController.Examples;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int coins;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private KinematicCharacterMotor KinematicMotor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       /*if(Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
           animator.SetFloat("Speed", 1f);
            Debug.Log("Reached 1");
        }

        if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        {
            animator.SetFloat("Speed", 0f);
            Debug.Log("Reached 0");
        }*/

        animator.SetFloat("Speed", KinematicMotor.Velocity.magnitude);   
        //Debug.Log(KinematicMotor.Velocity.magnitude);

        
    }

    float AnimationSpeed()
    {
        Vector3 Velocity = rb.angularVelocity;
        return Velocity.x;
    }

    public void AddCoins(int coinamt)
    {
        coins += coinamt;
        uiManager.ChangeScore(coins);

    }
}
