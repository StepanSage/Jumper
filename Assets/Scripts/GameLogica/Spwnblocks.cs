using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwnblocks : MonoBehaviour
{
    [SerializeField] private GameObject PrefansBloks;
    public void Spawn()
    {
        var bloks = Instantiate(PrefansBloks, new Vector3(Random.Range(1.30f , 2.15f), Random.Range(-0.7f, 2.0f) , 0 ), Quaternion.identity);
    }

    private void Start()
    {
        Spawn();
    }
}
