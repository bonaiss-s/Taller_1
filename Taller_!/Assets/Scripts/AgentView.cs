using UnityEngine;
using UnityEngine.InputSystem;

public class AgentView : MonoBehaviour {



  public Animator animator;
 
    public enum animations
    {
        walking,
        Run,
        Crouch,
        Heal,
        Hit,
        Idle
    }

    animations Animations;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        switch (Animations)
        {

            case animations.Idle:

                break;
        }
    }
}
