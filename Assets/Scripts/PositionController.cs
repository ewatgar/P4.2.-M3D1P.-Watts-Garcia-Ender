using UnityEngine;

public class PositionController : MonoBehaviour
{
    [Range(1, 20)] public float speed = 8;
    [SerializeField] public float jumpForce = 5;
    [SerializeField] public float gravity = 4;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float incPosicionX = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float incPosicionZ = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        float incPosicionY = -gravity*Time.deltaTime;

        /*
        if (Input.GetKey(KeyCode.Space)){
            incPosicionY = speed*Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftShift)){
            incPosicionY = -speed*Time.deltaTime;
        }*/

        if (Input.GetKey(KeyCode.Space) && characterController.isGrounded){
            incPosicionY = jumpForce*0.01f;
        } else if (Input.GetKey(KeyCode.LeftShift)){
            incPosicionY = -gravity*Time.deltaTime;
        }

        //transform.Translate(new Vector3(incPosicionX,0,incPosicionZ),Space.Self);
        //transform.Translate(new Vector3(0,incPosicionY,0),Space.World);
        characterController.Move(transform.TransformDirection(new Vector3(incPosicionX,0,incPosicionZ)));
        characterController.Move(new Vector3(0,incPosicionY,0));
    }
}
