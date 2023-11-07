using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour
{
    // Start is called before the first frame update

    private float velocidade = 6.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);   


        if (transform.position.x < -10.0f)
        {
            transform.position = new Vector3(10f,Random.Range(-4.0f, 4.0f),  0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("O objeto" + name + " colidiu com o objeto " + other.name);
        if (other.tag == "Tiro")
        {
            Destroy(other.gameObject);
        }
       
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                player.DanoAoPlayer();
            }
        }
        Destroy(this.gameObject);

    }








}
