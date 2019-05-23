using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionControler : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreControler scoreController;
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
        if(collision.gameObject.name == "LEFTRight" || collision.gameObject.name == "LEFT" || collision.gameObject.name == "LEFTLeft" || collision.gameObject.name == "RIGHTLeft"  || collision.gameObject.name == "RIGHT" || collision.gameObject.name == "RIGHTRight")
        {
            this.BounceFromRacket(collision);

        }else if(collision.gameObject.name == "WallLEFT")
        {
            Debug.Log("Collision with WallLEFT");
            this.scoreController.GoalPlayer2();

        }else if(collision.gameObject.name == "WallRIGHT")
        {
            Debug.Log("Collision with WallRIGHT");
            this.scoreController.GoalPlayer1();
        }
    }

}
