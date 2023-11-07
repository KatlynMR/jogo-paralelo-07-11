using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public float veloc ;
    public float entradaVertical ;
    public  GameObject _pfTiro;
    public float _tempoDeDisparo = 0.3f;
    public float podeDarTiro = 0.0f;
    public bool possoDarTiroTriplo = false;
    public GameObject _TiroTriploPrefab;
    public int vidas = 3;
    [SerializeField]
    private GameObject explosaoPlayerPrefab;
    public void DanoAoPlayer()
    {
        //vidas = vidas -1;
        vidas--;

        if (vidas < 1)
        {
            Instantiate(explosaoPlayerPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

    }
   
   void Start()
    {
       veloc = 3.0f ;
       transform.position = new Vector3(-7.09f,-0.06f,0); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { tiro(); }
      Movimento();
    }

    private void tiro()
{
    if (Time.time > podeDarTiro)
    {
        if (possoDarTiroTriplo == true)
        {
            Instantiate(_TiroTriploPrefab, transform.position + new Vector3(2, 0, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(_pfTiro, transform.position + new Vector3(1.07f, 0, 0), Quaternion.identity);
        }
        podeDarTiro = Time.time + _tempoDeDisparo;
    }
}

    public void LigarPUTiroTriplo()
{
    possoDarTiroTriplo = true;

    StartCoroutine(TiroTriploRotina());
}
      public IEnumerator TiroTriploRotina() {
        yield return new WaitForSeconds(6.0f);
        possoDarTiroTriplo = false;
    }

  
       
        private void Movimento() 
        {
        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * entradaVertical * Time.deltaTime*veloc);
        if (transform.position.y < -3.09f) 
        {
            transform.position = new Vector3(transform.position.x,-3.09f,0);
        }
        else if(transform.position.y > 2.57f)
        {
            transform.position = new Vector3(transform.position.x,2.57f,0);
        }

        }
  }

