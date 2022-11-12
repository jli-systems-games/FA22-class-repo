using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryAnimation : MonoBehaviour
{
    #region Animation Variables
    public Animator animator;
    private string currentState = "";
    #endregion

    #region Animation States
    public string MenuAppear;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void ChangeAnimationState(string newState)
    {
        if(currentState == newState)
            return;

            animator.Play(newState);

            currentState = newState;
    }
}
