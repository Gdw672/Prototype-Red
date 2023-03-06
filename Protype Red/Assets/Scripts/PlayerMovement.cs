using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float sizePlayer;
   private Rigidbody2D playerBody;
   internal bool isPressed;
   [SerializeField] private float speedOfWalk;
   [SerializeField] private Vector2 vectorMove;
    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        sizePlayer = gameObject.transform.localScale.x;
    }

    public void tranformateSizePlayer(bool isLeft)
    {
        if(isLeft)
            gameObject.transform.localScale = new Vector3(-sizePlayer, sizePlayer, sizePlayer);
 
        else
            gameObject.transform.localScale = new Vector3(sizePlayer, sizePlayer, sizePlayer);
    }

    public void OnDownHorizontal(float speed)
    {
        vectorMove = new Vector2(speed, 0);
        isPressed = true;
    }

    public void OnDownVertical(float speed)
    {
        vectorMove = new Vector2(0, speed);
        isPressed = true;
    }

    public void OnUp()
    {
        isPressed = false;
    }

    private void FixedUpdate()
    {
        if(isPressed)
        {
            playerBody.transform.Translate(vectorMove * speedOfWalk);
        }
    }
}
