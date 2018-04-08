using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
       w and s control speed 
       mouse controls potential turn
       a and d control strafing
    */

    
    private float speed, turn, strafe;

    [SerializeField]
    private Animator anim;

    #region

    private void Update()
    {
        ControlSpeed();
        ControlTurn();
       // ControlStrafe();
    }

    private void ControlSpeed()
    {
        
        speed = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", speed);
      
    }

    private void ControlTurn()
    {
        turn = Input.GetAxis("Horizontal");
        anim.SetFloat("Turn", turn);
    }

    private void ControlStrafe()
    {
        
    }

    #endregion
}
