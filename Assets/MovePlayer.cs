using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }

        moveDirection.y -= gravity * Time.deltaTime;

        //Move player
        controller.Move(moveDirection * Time.deltaTime);

        //Rotate player
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

    }
}
