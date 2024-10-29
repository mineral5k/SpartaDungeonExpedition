using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerCondition condition;
    public Interaction interaction;

    private void Awake()
    {
        GameManager.Instance.Player = this;
        controller = GetComponent<PlayerController>(); 
        condition = GetComponent<PlayerCondition>();
        interaction = GetComponent<Interaction>();

    }
}
