using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour
{
    #region Animation Variables
    private Animator _animator;
    private string _currentState;
    #endregion

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    public void ChangeAnimationState(string newState)
        {
        if(_currentState == newState)
        return;

        _animator.Play(newState);

        _currentState = newState;
     
        }

}
