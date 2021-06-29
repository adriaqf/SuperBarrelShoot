using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public Rigidbody2D rb2d;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = new Vector2(GameController.instanceGameController.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instanceGameController.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
