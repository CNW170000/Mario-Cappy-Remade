using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CappyScript : MonoBehaviour
{
    //[SerializeField] Text _currentScoreTextView;

    //public static int _currentCoin;
    public float speed = 12f;
    public Rigidbody rigidPlayer;
    public float throwDistance = 10f;
    public float gravity = -9.81f;
    Vector3 velocity;

    private Rigidbody rigid;

    private Vector3 endPosition = new Vector3(-8, 0, -8);
    // Start is called before the first frame update
    private void Start()
    {
        rigid = transform.GetComponent<Rigidbody>();
        //    GameObject.Find("Third Person Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, -3f, 0f, Space.Self);

        //if (Input.GetButton("Fire1") && transform.position != endPosition)
        //{
        //    Vector3 moved = transform.forward * throwDistance;
        //    this.transform.(moved * speed * Time.deltaTime);
        //}
    }

   // void OnCollisionEnter(Collision collidedWithThis)
    //{
    //    Debug.Log("OnCollisionEnter called");
   //     if (collidedWithThis.transform.tag == "Character")
    //    {
    //        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
   //         rigidPlayer.velocity = transform.up * speed; //speed is a number variable
   // }
    /* public void IncreaseCoin(int coinIncrease)
     {
         // increase coin
         _currentCoin += coinIncrease;
         // update coin display, so we can see the new coin count
         _currentCoinTextView.text = "Coin: " + _currentCoin.ToString();
     }*/
}
