using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionControler : MonoBehaviour
{
    public BallMovement ballMovement;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHigh = c.collider.bounds.size.y;

        float x;

        if (c.gameObject.name == "LEFTRight")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHigh;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
           

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "LEFTRight" || collision.gameObject.name == "RIGHTLeft")
        {
            this.BounceFromRacket(collision);

        }else if(collision.gameObject.name == "WallLEFT")
        {
            Debug.Log("Collision with WallLEFT");

        }else if(collision.gameObject.name == "WallRIGHT")
        {
            Debug.Log("Collision with WallRIGHT");
        }
    }

}
