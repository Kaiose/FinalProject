using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    bool Dead = false;

    [SerializeField]
    private int Health = 10;
    private int Damage = 10;


    public GameObject SelectObject;
    protected readonly int m_HashDeadPara = Animator.StringToHash("Dead");
    public Animator animator;
    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        IsTarget();

        if (Dead)
        {
            animator.SetTrigger(m_HashDeadPara);

        }
    }



    public bool GetDead()
    {
        return Dead;
    }

    public void GetDamaged()
    {
        Health -= Damage;
        if(Health <= 0)
        {
            Dead = true;
        }
    }

    void IsTarget()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("down Right MouseButton");
            SelectObject.SetActive(true);
            PlayerInputManager.getInstance.Shot(PlayerInputManager.Direction.B);
            GetDamaged();
        }
    }

}

