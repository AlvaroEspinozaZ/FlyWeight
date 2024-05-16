using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyParticleSys
{
    public class MyPS : MonoBehaviour
    {
        [Header("Atributes Static")]
        [SerializeField] public int cantParticles=50;
        [SerializeField] public float tiempoAper = 0.6f;
        [SerializeField] public float frame = 0;
        [SerializeField] public GameObject Prefabs;        
        [SerializeField] public List<GameObject> listParticles;
        [Header("Atributes Dinamic")]
        [SerializeField] static Color colors;
        [SerializeField] static Vector3 pos;
        private void Start()
        {

            for (int i = 0; i < cantParticles; i++)
            {
                frame += Time.deltaTime;
                GameObject tmp = Instantiate(Prefabs);
                listParticles.Add(tmp);
                if (frame < tiempoAper)
                {
                    tmp.SetActive(false);
                    frame = 0;
                }
            }
        }

        private void Update()
        {


        }
    }
}
