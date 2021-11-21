using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
        // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("X_Speed", change.x);
        animator.SetFloat("Y_Speed", change.y);

        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (Mathf.Abs(change.x) > Mathf.Abs(change.y))
            {
                change.y = 0;
            }
            else
            {
                change.x = 0;
            }
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {

        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime
            );
    }
}

