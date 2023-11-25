using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeObjetos : MonoBehaviour
{
    [SerializeField]
    private GameObject inimigoPrefab;

    [SerializeField]
    private GameObject[] powerUps;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotinaGeracaoInimigo());
        StartCoroutine(RotinaGeracaoPowerUp());
    }

    IEnumerator RotinaGeracaoInimigo()
    {
        while ( 1==1)
        {
            Instantiate(inimigoPrefab, new Vector3(Random.Range(12.0f, 18.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
            yield return new WaitForSeconds(6);

        }


    }
    IEnumerator RotinaGeracaoPowerUp()
    {
        while ( 1==1)
        {
            int powerUpsAleatorio = Random.Range(0, 3);
            Instantiate(powerUps[powerUpsAleatorio], new Vector3(Random.Range(12.0f, 18.0f), Random.Range(-4.0f, 4.0f), 0), Quaternion.identity);
            yield return new WaitForSeconds (6);
        }
    }


}
