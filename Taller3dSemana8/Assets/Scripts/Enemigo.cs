using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bala"))
        {
            Destroy(other.gameObject);
            GameObject.Find("Generador Niveles").GetComponent<GeneradorNiveles>().EnemigoDerrotado();
            Destroy(gameObject);
        }
    }
}
