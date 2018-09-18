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
    BoxCollider2D boxCollider;
    
    // Use this for initialization
    void Start() {
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        IsTarget();

    }
    
    public bool GetDead()
    {
        return Dead;
    }


    public void GetDamaged()
    {
        Health -= Damage;
        if (Health <= 0)
        {
            Dead = true;
            SelectObject.SetActive(false);
            animator.SetTrigger(m_HashDeadPara);
        }
    }


    void IsTarget()
    {

        if (Input.GetMouseButtonDown(0)){

            SelectObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 vector = Input.mousePosition;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(vector);
            if (Mathf.Abs(boxCollider.bounds.center.x - mousePos.x) <= boxCollider.bounds.extents.x &&
                Mathf.Abs(boxCollider.bounds.center.y - mousePos.y) <= boxCollider.bounds.extents.y)
            {
                SelectObject.SetActive(true);
                PlayerInputManager.getInstance.Shot(PlayerInputManager.Direction.B);
                GetDamaged();
            }
        }
    }
    


    
}

