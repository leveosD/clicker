using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    [SerializeField] Hero killer;
    [SerializeField] Victim victim;
    const int MAX = 5;
    bool win;
    public bool Win
    {
        get { return win; }
        private set { win = value; }
    }

    bool isActive;
    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    Color defaultColor;
    Color invisible;

    [SerializeField] Image i;
    [SerializeField] Image bI;
    [SerializeField] Button b;
    [SerializeField] Sprite gameOver;
    [SerializeField] Sprite youWIn;

    // Start is called before the first frame update
    void Start()
    {
        IsActive = true;
        //i.enabled = false;
        b.enabled = false;
        //bI.enabled = false;
        defaultColor = i.color;
        bI.color = invisible;
        i.color = invisible;
        invisible = new Color(255, 255, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            if (killer.Demon && victim.Look)
            {
                Debug.Log("Game Over");
                IsActive = false;
                Win= false;
            }
            if (killer.Count == MAX)
            {
                Debug.Log("You Win!");
                IsActive = false;
                Win = true;
            }
        }
        else
        {
            i.sprite = Win ? youWIn : gameOver;
            b.enabled = true;
            bI.color = defaultColor;
            i.color = defaultColor;
        }
    }

    public void ClickButton()
    {
        killer.Count = 0;
        IsActive = true;
        b.enabled = false;
        bI.color = invisible;
        i.color = invisible;
        //bI.sprite = null;
        //i.sprite = null;
        //bI.enabled = false;
        //i.enabled = false;
    }
}
