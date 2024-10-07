using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victim : MonoBehaviour
{
    bool delay;
    Animator anim;

    public bool Look;
    [SerializeField] Global game;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        delay = true;
        Look = false;
        StartCoroutine(MakeDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if (!delay && game.IsActive)
        {
            delay = true;
            anim.SetBool("look", true);
            Look = true;
            StartCoroutine(MakeDelay());
        }
    }

    IEnumerator MakeDelay()
    {
        yield return new WaitForSeconds(Random.Range(3, 7));
        delay = false;
    }

    void SetIdle()
    {
        anim.SetBool("look", false);
        Look = false;
    }
}
