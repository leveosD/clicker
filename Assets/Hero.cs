using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    Animator anim;
    public bool Demon;
    public int Count;

    [SerializeField] Global game;

    // Start is called before the first frame update
    void Start()
    {
        Demon = false;
        anim = GetComponent<Animator>();
        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && game.IsActive)
        {
            anim.SetBool("Demon", true);
            Demon = true;
        }
    }

    void SetAngel()
    {
        anim.SetBool("Demon", false);
        Demon = false;
        Count += 1;
    }
}
