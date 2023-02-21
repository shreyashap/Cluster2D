using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    public void MoveUp()
    {
        playerAnim.SetTrigger("MoveUp");
    }

    public void MoveRight()
    {
        playerAnim.SetTrigger("MoveRight");
    }

    public void MoveLeft()
    {
        playerAnim.SetTrigger("MoveLeft");
    }

    public void MoveDown()
    {
        playerAnim.SetTrigger("MoveDown");
    }
}
