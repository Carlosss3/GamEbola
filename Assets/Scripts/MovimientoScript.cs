using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {

	public int vhorizontal = 1;
	public int vvertical = 1; //velocidades verticales y horizontales
	public bool estavivo = true;
	Vector3 movimiento;
	Vector3 posicionRaton;


	
	// Update is called once per frame
	void Update () {

		/*
		 * 
		 * Para mover al pajaro (con controles predeterminados) vhor y vver es la sensibilidad


		var v = Input.GetAxis ("Vertical");
		var h = Input.GetAxis ("Horizontal");    

		movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0); // 

		transform.Translate (movimiento * Time.deltaTime);
*/

		posicionRaton = Input.mousePosition;

		posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton); //convierte coordenadas del raton a la camara del videojuego. Indispensable.

		if (Input.GetMouseButton (0) & estavivo) {
				transform.position = Vector2.Lerp (transform.position, posicionRaton, vvertical * 0.01f);	//Lerp desde donde, hasta donde y a que velocidad. el 0.1f para pasarlo a float por que es muy grande.
				}
		}
}
