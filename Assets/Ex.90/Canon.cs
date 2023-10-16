using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    //Con una esfera y un cubo crea una especie de ca��n.Haz que este ca��n rote
    //constantemente.Cuando se pulse la barra espaciadora, una bala debe instanciarse en la
    //punta del ca��n e ir en la direcci�n en la que apunta el ca��n. La bala debe destruirse a los 5
    //segundos de aparecer


    public float speed = 200f;
    public GameObject bolaPrefab;

    private void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBolas();
        }
    }
    private void SpawnBolas()
    {
        //instanciar las bolas desde el empty group al pulsar espacio
     Instantiate(bolaPrefab, transform.position, Quaternion.identity);
    }
}
