using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cute : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 maxVelocity = new Vector2();
    public float jump = 8f;
    public bool standing;
    public float standingThreshold = 4f;
    public float airSpeedMultiplier = .3f;

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;
    private PlayerController controller;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
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

        if (controller.moving.x != 0)
        {
            if (absVelX < maxVelocity.x)
            {
                var newSpeed = speed * controller.moving.x;
                forceX = standing ? newSpeed: (newSpeed * airSpeedMultiplier);
                renderer2D.flipX = forceX > 0;
            }
            
        }
        
            if (controller.moving.y > 0)
        {
            if(absVelY < maxVelocity.y)
            {
                forceY = jump * controller.moving.y;
            }
        }
            body2D.AddForce(new Vector2(forceX, forceY));
        
    }
}
