using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour

{
    public float moveSpeed = 5f;
    public LayerMask solidObjectsLayer;
    public LayerMask pokes;
    public LayerMask interactableLayer;
    public bool move;

    private Vector2 movement;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    
    private void Update()
    {
        if (!move)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            if (movement.x != 0) movement.y = 0;

            if (movement != Vector2.zero)
            {
                animator.SetFloat("moveX", movement.x);
                animator.SetFloat("moveY",movement.y);
                var targetPos = transform.position;
                targetPos.x += movement.x;
                targetPos.y += movement.y;

                if (IsWalkable(targetPos))
                {

                    StartCoroutine(Move(targetPos));
                }
            }
        }
        animator.SetBool("move", move);
        Interact();

    }

    void Interact()
    {
        var faceDir = new Vector3(animator.GetFloat("moveX"), animator.GetFloat("moveY"));
        var interactPos=transform.position + faceDir;

        Debug.DrawLine(transform.position, interactPos, Color.green, 0.5f);
    }

    IEnumerator Move(Vector3 targetPos)
    {
        move = true;
        while ((targetPos-transform.position).sqrMagnitude>Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        move = false;

        
    }
    private bool IsWalkable (Vector3 targetPos)
    {
        if(Physics2D.OverlapCircle(targetPos,0.1f,solidObjectsLayer | interactableLayer)!=null)
        {
            return false;
        }
        return true;
    }

    
}
