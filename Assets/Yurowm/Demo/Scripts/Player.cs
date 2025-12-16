using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    PlayerController controller;
    Vector3 moveVec;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveVec = moveInput.normalized;

        transform.position += moveVec * speed * Time.deltaTime;
    }
}
