﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Ball))]
public class DragLaunch : MonoBehaviour {

    private Ball ball;

    private Vector3 dragStart, dragEnd;
    private float startTime, endTime;

	// Use this for initialization
	void Start () {
        ball = this.GetComponent<Ball>();
        
	}

    public void MoveStart(float amount)
    {
        if (ball.inPlay == false)
        {
            Debug.Log("Moving...");
            ball.transform.Translate(new Vector3(amount, 0, 0));
        }
        
    }

    public void DragStart ()
    {
        // Capture time & position of drag start
        startTime = Time.time;
        dragStart = Input.mousePosition;
    }

    public void DragEnd ()
    {
        // Launch the ball
        dragEnd = Input.mousePosition;
        endTime = Time.time;

        float dragDuration = endTime - startTime;

        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

        Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeedZ);

        ball.Launch(launchVelocity);
    }
}
