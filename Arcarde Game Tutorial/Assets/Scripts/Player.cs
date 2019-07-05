using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 maxVelocity = new Vector2();
    public float jump = 8f;
    public bool standing;
    public float standingThreshold = 4f;

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var absVelX = Mathf.Abs(body2D.velocity.x);
        //absVelX = absolute Velocity X (value)
        var absVelY = Mathf.Abs(body2D.velocity.y);

        if(absVelY <= standingThreshold)
        {
            standing = true;
        }
        else
        {
            standing = false;
        }

        var forceX = 0f;
        var forceY = 0f;

        if (Input.GetKey("right"))
        {
            if (absVelX < maxVelocity.x)
            {
                forceX = speed;
            }

            renderer2D.flipX = false;
        }
        else if (Input.GetKey("left"))
        {
            if (absVelX < maxVelocity.x)
            {
                forceX = -speed;
            }

            renderer2D.flipX = true;
        }
            if (Input.GetKey("up"))
        {
            if(absVelY < maxVelocity.y)
            {
                forceY = jump;
            }
        }
            body2D.AddForce(new Vector2(forceX, forceY));
        
    }
}
