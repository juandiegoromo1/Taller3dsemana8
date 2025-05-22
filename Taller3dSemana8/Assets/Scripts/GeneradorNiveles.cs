using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;

public class GeneradorNiveles : MonoBehaviour
{
    [SerializeField] List<GameObject> nivelList;
    public List<GameObject> EnemigosSpawneados;
    [SerializeField] bool primernivel;
    private int nivel;
    private int EnemigosDerrotados;
    [SerializeField] TextMeshProUGUI niveltexto;
    void Start()
    {
        if (primernivel == true)
        {
            Instantiate(nivelList[0]);
            GameObject[] enemigostemporal = GameObject.FindGameObjectsWithTag("enemigo");

            foreach (GameObject obj in enemigostemporal)
            {
                EnemigosSpawneados.Add(obj);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(EnemigosSpawneados.Count);
    }
    public void EnemigoDerrotado()
    {
        EnemigosDerrotados++;
        if(EnemigosDerrotados >= EnemigosSpawneados.Count)
        {
            Invoke("SiguienteNivel", 1f);
        }
    }
    public void SiguienteNivel()
    {
        nivel++;
        niveltexto.text = "Nivel " + (nivel + 1);
        EnemigosDerrotados = 0;
        EnemigosSpawneados.Clear();
        Instantiate(nivelList[nivel]);
        GameObject[] enemigostemporal = GameObject.FindGameObjectsWithTag("enemigo");

        foreach (GameObject obj in enemigostemporal)
        {
            EnemigosSpawneados.Add(obj);
        }
    }
}
