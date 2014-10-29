using UnityEngine;
using System.Collections;

public class GeneradorColumnas : MonoBehaviour {

	public GameObject[] columna; //objeto que generamos
	public float tiempoespera = 3;		// Cada cuanto la generaremos
	Vector3 posicion;
	float timer = 0;		// esta variable empezara a contar cuando el juego comience

	// Use this for initialization
	void Start () {
		posicion = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timer) {
			var altura = Random.Range(-3f,3f);
			var tipocolumna = Random.Range (0,columna.Length);



						var nuevacolumna = (GameObject)Instantiate(columna[tipocolumna], new Vector3(posicion.x, posicion.y+altura,posicion.z), transform.rotation);	
						timer = Time.time + tiempoespera;
						Destroy(nuevacolumna,7);
				}
	
	}
}
