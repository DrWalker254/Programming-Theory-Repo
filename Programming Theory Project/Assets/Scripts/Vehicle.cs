using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //#### ENCAPSULATION
    protected float _speed = 45.0f;
    protected float _turnSpeed = 35.0f;

    public virtual float Speed
    {
        get { return _speed; }
        protected set
        {
            if (value >= 0 && value <= 100)
            {
                _speed = value;
            }
            else
            {
                Debug.LogWarning("speed must be between 0 and 100!");
            }
        }
    }

    public virtual float TurnSpeed
    {
        get { return _turnSpeed; }
        protected set
        {
            if (value >= 0 && value <= 50)
            {
                _turnSpeed = value;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //#### ABSTRACTION
        Move();
    }

    protected virtual void Move() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");

        // Moves the Vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        // Turns the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);
    }
}
