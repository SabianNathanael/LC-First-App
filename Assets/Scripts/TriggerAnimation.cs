using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();

    }   

    // Update is called once per frame
    public void SetTrigger()
    {
        Debug.Log("sasd");
        _animator.SetTrigger("SetAttack");
    }
}
