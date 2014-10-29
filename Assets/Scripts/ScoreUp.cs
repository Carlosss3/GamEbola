using UnityEngine;
using System.Collections;
using UnityEngine.UI;		// HAY QUE INCLUIRLO SIEMPRE SI QUEREMOS USAR COSAS DE UI

public class ScoreUp : MonoBehaviour {

	public Text texto;

	void Start(){

		texto = GameObject.Find ("TextoNivel").GetComponent<Text> ();

	}

	void OnTriggerEnter2D(Collider2D col){
		GameControl.score = GameControl.score + 1;
		//Debug.Log (GameControl.score);

		texto.text = "LEVEL" + GameControl.score.ToString ();
	}	
}
