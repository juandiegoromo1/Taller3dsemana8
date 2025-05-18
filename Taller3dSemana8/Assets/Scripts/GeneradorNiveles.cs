using UnityEngine;

public class GeneradorNiveles : MonoBehaviour
{
    [SerializeField] GameObject nivel;
    [SerializeField] bool primernivel;
    void Start()
    {
        if (primernivel == true)
        {
            Instantiate(nivel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
