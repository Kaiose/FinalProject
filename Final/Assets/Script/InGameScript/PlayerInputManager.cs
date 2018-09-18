using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour {

    static protected PlayerInputManager playerInputManager;
    static public PlayerInputManager getInstance {  get { return playerInputManager;  } }

    private void Awake()
    {
        playerInputManager = this;
    }

    public enum Direction
    {
        N,
        T,
        TTR,
        TR,
        RRT,
        R,
        RRB,
        RB,
        BBR,
        B,
        BBL,
        BL,
        LLB,
        L,
        LLT,
        LT,
        TTL,
    }

    private Direction direction;
    public SpriteRenderer spriteRenderer;
    Animator animator = null;

    [SerializeField]
    private float Speed;

    protected readonly int m_HashWalkPara = Animator.StringToHash("Walk");
    protected readonly int m_HashWalkTopPara = Animator.StringToHash("Walk_T");
    protected readonly int m_HashWalkTopRightPara = Animator.StringToHash("Walk_TR");
    protected readonly int m_HashWalkRightPara = Animator.StringToHash("Walk_R");
    protected readonly int m_HashWalkBottomRightPara = Animator.StringToHash("Walk_BR");
    protected readonly int m_HashWalkBottomPara = Animator.StringToHash("Walk_B");
    protected readonly int m_HashWalkBottomLeftPara = Animator.StringToHash("Walk_BL");
    protected readonly int m_HashWalkLeftPara = Animator.StringToHash("Walk_L");
    protected readonly int m_HashWalkTopLeftPara = Animator.StringToHash("Walk_TL");

    protected readonly int m_HashShotPara = Animator.StringToHash("Shot");
    protected readonly int m_HashShotTopPara = Animator.StringToHash("Shot_T");
    protected readonly int m_HashShotTopRightPara = Animator.StringToHash("Shot_TR");
    protected readonly int m_HashShotRightPara = Animator.StringToHash("Shot_R");
    protected readonly int m_HashShotBottomRightPara = Animator.StringToHash("Shot_BR");
    protected readonly int m_HashShotBottomPara = Animator.StringToHash("Shot_B");
    protected readonly int m_HashShotBottomLeftPara = Animator.StringToHash("Shot_BL");
    protected readonly int m_HashShotLeftPara = Animator.StringToHash("Shot_L");
    protected readonly int m_HashShotTopLeftPara = Animator.StringToHash("Shot_TL");

    protected readonly int m_HashDeadPara = Animator.StringToHash("Dead");
    // Use this for initialization


    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        animator = GetComponent<Animator>();
        direction = Direction.N;
        Speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        CheckInputKey();
        Walk();
	}

    public void Shot(Direction dir)
    {
        switch (dir)
        {
            case Direction.N:
                return;

            case Direction.T:
                animator.SetTrigger(m_HashShotTopPara);
                spriteRenderer.flipX = false;
                return;

            case Direction.TTR:
                // transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z);
                return;

            case Direction.TR:

                animator.SetTrigger(m_HashShotTopRightPara);
                spriteRenderer.flipX = false;
                return;

            case Direction.RRT:
                return;

            case Direction.R:

                animator.SetTrigger(m_HashShotRightPara);

                spriteRenderer.flipX = false;

                return;

            case Direction.RRB:
                return;

            case Direction.RB:

                animator.SetTrigger(m_HashShotBottomRightPara);
                spriteRenderer.flipX = false;
                return;

            case Direction.BBR:
                return;

            case Direction.B:
                print(" Input Right Shot Button" + dir.ToString());

                animator.SetTrigger(m_HashShotBottomPara);
                spriteRenderer.flipX = false;

                return;

            case Direction.BBL:
                return;

            case Direction.BL:

                spriteRenderer.flipX = true;

                animator.SetTrigger(m_HashShotBottomLeftPara);

                return;

            case Direction.LLB:
                return;
            case Direction.L:
                spriteRenderer.flipX = true;


                animator.SetTrigger(m_HashShotLeftPara);

                return;

            case Direction.LLT:
                return;

            case Direction.LT:

                spriteRenderer.flipX = true;


                animator.SetTrigger(m_HashShotTopLeftPara);
                return;

            case Direction.TTL:
                return;

        }
    }


    void Walk()
    {
      //  print(direction.ToString());
        switch (direction)
        {
            case Direction.N:
                return;

            case Direction.T:
                transform.position = new Vector3(transform.position.x, transform.position.y + Speed*Time.deltaTime, transform.position.z);
                animator.SetBool(m_HashWalkTopPara, true);
                spriteRenderer.flipX = false;
                return;

            case Direction.TTR:
               // transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z);
                return;

            case Direction.TR:
                transform.position = new Vector3(transform.position.x +Speed*Time.deltaTime/Mathf.Sqrt(2) , transform.position.y + Speed * Time.deltaTime / Mathf.Sqrt(2) , transform.position.z);
                animator.SetBool(m_HashWalkTopRightPara, true);
                spriteRenderer.flipX = false;
                return;

            case Direction.RRT:
                return;

            case Direction.R:
                transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
                animator.SetBool(m_HashWalkRightPara, true);

                spriteRenderer.flipX = false;

                return;

            case Direction.RRB:
                return;

            case Direction.RB:
                transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime / Mathf.Sqrt(2), transform.position.y - Speed * Time.deltaTime / Mathf.Sqrt(2), transform.position.z);
                animator.SetBool(m_HashWalkBottomRightPara, true);

                spriteRenderer.flipX = false;
                return;

            case Direction.BBR:
                return;

            case Direction.B:
                transform.position = new Vector3(transform.position.x , transform.position.y - Speed * Time.deltaTime, transform.position.z);
                animator.SetBool(m_HashWalkBottomPara, true);
                spriteRenderer.flipX = false;
                
                return;

            case Direction.BBL:
                return;

            case Direction.BL:



                spriteRenderer.flipX = true ;
                transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime / Mathf.Sqrt(2), transform.position.y - Speed * Time.deltaTime / Mathf.Sqrt(2), transform.position.z);
                animator.SetBool(m_HashWalkBottomLeftPara, true);

                return;

            case Direction.LLB:
                return;
            case Direction.L:
                spriteRenderer.flipX = true;

                transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime, transform.position.y, transform.position.z);
                animator.SetBool(m_HashWalkLeftPara, true);

                

                return;

            case Direction.LLT:
                return;

            case Direction.LT:

                spriteRenderer.flipX = true;
                transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime / Mathf.Sqrt(2), transform.position.y + Speed * Time.deltaTime / Mathf.Sqrt(2), transform.position.z);

                animator.SetBool(m_HashWalkTopLeftPara, true);
                return;

            case Direction.TTL:
                return;

        }
    }

    void CheckInputKey()
    {


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            InitializeAnimationPara(m_HashWalkTopLeftPara);
         //   animator.SetBool(m_HashWalkPara, true);
            direction = Direction.LT;
        }

        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            InitializeAnimationPara(m_HashWalkTopRightPara);
       //     animator.SetBool(m_HashWalkPara, true);
            direction = Direction.TR;
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            InitializeAnimationPara(m_HashWalkBottomRightPara);
       //     animator.SetBool(m_HashWalkPara, true);
            direction = Direction.RB;
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            InitializeAnimationPara(m_HashWalkBottomLeftPara);
        //    animator.SetBool(m_HashWalkPara, true);
            direction = Direction.BL;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            InitializeAnimationPara(m_HashWalkLeftPara);
        //    animator.SetBool(m_HashWalkPara, true);
            direction = Direction.L;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            InitializeAnimationPara(m_HashWalkTopPara);
        //    animator.SetBool(m_HashWalkPara, true);
            direction = Direction.T;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            InitializeAnimationPara(m_HashWalkRightPara);
       //     animator.SetBool(m_HashWalkPara, true);
            direction = Direction.R;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            InitializeAnimationPara(m_HashWalkBottomPara);
       //     animator.SetBool(m_HashWalkPara, true);
            direction = Direction.B;
        }
        else
        {

            InitializeAnimationPara(0);  // 자기껄 빼고 이
            direction = Direction.N;
        }

    }


    void Dead()
    {
        direction = Direction.N;
        animator.SetBool(m_HashWalkPara, false);
        animator.SetTrigger(m_HashDeadPara);
    }
    
    void InitializeAnimationPara(int HashPara)
    {
        
        if(HashPara == m_HashWalkTopPara)
        {
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        if (HashPara == m_HashWalkTopRightPara)
        {
            animator.SetBool(m_HashWalkPara, false);
            animator.SetBool(m_HashWalkTopPara, false);

            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        if (HashPara == m_HashWalkRightPara)
        {
            animator.SetBool(m_HashWalkPara, false);
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);

            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        if (HashPara == m_HashWalkBottomRightPara)
        {
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);

            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        if (HashPara == m_HashWalkBottomPara)
        {
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);

            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        if (HashPara == m_HashWalkBottomLeftPara)
        {
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);

            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        if (HashPara == m_HashWalkLeftPara)
        {
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);

            animator.SetBool(m_HashWalkTopLeftPara, false);
        }

        if (HashPara == m_HashWalkTopLeftPara)
        {
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);

        }
        if(HashPara == 0)
        {
            //     animator.SetBool(m_HashShotPara, false);
            animator.SetBool(m_HashWalkTopPara, false);
            animator.SetBool(m_HashWalkTopRightPara, false);
            animator.SetBool(m_HashWalkRightPara, false);
            animator.SetBool(m_HashWalkBottomRightPara, false);
            animator.SetBool(m_HashWalkBottomPara, false);
            animator.SetBool(m_HashWalkBottomLeftPara, false);
            animator.SetBool(m_HashWalkLeftPara, false);
            animator.SetBool(m_HashWalkTopLeftPara, false);
        }
        ////     animator.SetBool(m_HashShotPara, false);
        //     animator.SetBool(m_HashShotTopPara, false);
        //     animator.SetBool(m_HashShotTopRightPara, false);
        //     animator.SetBool(m_HashShotRightPara, false);
        //     animator.SetBool(m_HashShotBottomRightPara, false);
        //     animator.SetBool(m_HashShotBottomPara, false);
        //     animator.SetBool(m_HashShotBottomLeftPara, false);
        //     animator.SetBool(m_HashShotLeftPara, false);
        //     animator.SetBool(m_HashShotTopLeftPara, false);
    }
}
