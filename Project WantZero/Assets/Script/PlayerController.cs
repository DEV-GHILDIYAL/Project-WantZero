using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score;
    public int lowscore;
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] Joystick _joystick;
    public LevelBoundary levelBoundary;
    float horizontalMove = 0f;
    public MainGame mg;

    public float _moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mg = FindAnyObjectByType<MainGame>();
        _rigidbody = GetComponent<Rigidbody>();
        _joystick = FindAnyObjectByType<Joystick>();
        levelBoundary = FindAnyObjectByType<LevelBoundary>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            if (_joystick.Horizontal >= 0.2f)
            {
                if (transform.position.x <= levelBoundary.rightSide)
                {
                    horizontalMove = _moveSpeed * Time.deltaTime;
                    _rigidbody.AddForce(horizontalMove, 0, 0);
                }
                else if (transform.position.x > levelBoundary.rightSide)
                {
                    transform.position = new Vector3(3f, transform.position.y, transform.position.z); ;
                }
            }
            else if (_joystick.Horizontal <= -0.2f)
            {
                if (transform.position.x >= levelBoundary.leftSide)
                {
                    horizontalMove = -_moveSpeed * Time.deltaTime;
                    _rigidbody.AddForce(horizontalMove, 0, 0);
                }
                else if (transform.position.x < levelBoundary.leftSide)
                {
                    transform.position = new Vector3(-3f, transform.position.y, transform.position.z);
                }
            }
            else
            {
                horizontalMove = 0;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }

            transform.Translate(horizontalMove, 0, 0);
    }

    private void Update()
    {
        if(lowscore > score)
        {
            lowscore = score;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.collider.tag == "Board")
        {
            String name = collision.gameObject.name;
            RandomNumberGenerator boardNum = collision.gameObject.GetComponentInParent<RandomNumberGenerator>();
            if(name == "1")
            {
                Debug.Log("1");
                int num1 = boardNum.randomNum1;
                mg.pointsText.text = (Convert.ToInt32(mg.pointsText.text) + num1).ToString();
            }else if(name == "2")
            {
                Debug.Log("2");
                int num2 = boardNum.randomNum2;
                mg.pointsText.text = (Convert.ToInt32(mg.pointsText.text) + num2).ToString();
            }
            else if (name == "3")
            {
                Debug.Log("3");
                int num3 = boardNum.randomNum3;
                mg.pointsText.text = (Convert.ToInt32(mg.pointsText.text) + num3).ToString();
            }
        }
    }
}
