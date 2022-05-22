using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private Vector3 charPos;
    [SerializeField] private GameObject _camera;
    private int sayi;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>(); //caching spriteRenderer
        r2d = GetComponent<Rigidbody2D>(); //caching r2d  
        _animator = GetComponent<Animator>(); //caching anim     
        charPos = transform.position;
        sayi = 1;

    }

    private void FixedUpdate()
    {
        //r2d.velocity = new Vector2(speed, 0f);
        //_camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z = -1.0f);     //titremeler oluyor dedi hoca
        sayi = 2;
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    speed = 1.0f;
        //    //Debug.Log("Hýz 1.0f");
        //}
        //else
        //{
        //    speed = 0.0f;
        //    //Debug.Log("Hýz 0.0f");
        //}
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;   //hesaplanan pozisyon karaktere iþlensin
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("speed", 0.0f);
        }
        else
        {
            _animator.SetFloat("speed", 1.0f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
        sayi = 3;
        Debug.Log("Update" + sayi);
    }

    private void LateUpdate()
    {
        //_camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z = -1.0f);
        sayi = 4;
    }

}
