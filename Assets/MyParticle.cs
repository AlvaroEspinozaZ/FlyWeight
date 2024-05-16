using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyParticle : MonoBehaviour
{
    [Header("Atributes Static")]
    [SerializeField] public Material _material;
    [SerializeField] public Rigidbody _rgb;
    [SerializeField] public float velocidad = 5;
    [SerializeField] public float tiempoLife = 3;
    [SerializeField] private float frame = 0;
    [Header("Atributes Dinamic")]
    [SerializeField] static Color colors;
    [SerializeField] static Vector3 pos;
    private void Start()
    {
        _rgb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        _rgb.velocity = GetParticleDirection()*velocidad;
    }
    private void Update()
    {
        frame += (1*Time.deltaTime);

        if (frame > tiempoLife)
            {
                gameObject.SetActive(false);
            frame = 0;
            }
       
    }
    public Vector3 GetParticlePosition()
    {
        Vector3 newPos = transform.position;
        return newPos;
    }
    public Vector3 GetParticleDirection()
    {

        Vector3 newPos = new Vector3(Random.Range(-0.99f,0.99f), Random.Range(-0.99f, 0.99f), Random.Range(-0.99f, 0.99f));

        return newPos;
    }
}
