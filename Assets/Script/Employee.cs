using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Employee : MonoBehaviour {
	public GameObject reset;
	public GameObject manager_slider;
	public GameObject programmer_slider;
	public GameObject designer_slider;
	public GameObject document_slider;

	public float manager_value = 0;
	public float programmer_value = 0;
	public float designer_value = 0;
	public float document_value = 0;

	// Use this for initialization
	void Start () {
		Button reset_btn = reset.GetComponent<Button> ();
		Random rand = new Random ();

		reset_employee_status ();

		//reset_btn.onClick.AddListener (set_zero_employee_status);
		reset_btn.onClick.AddListener (reset_employee_status);

	}
	
	// Update is called once per frame
	void Update () {

	}

	void reset_employee_status(){
		manager_value = Random.Range (0.0f, 1.0f);
		programmer_value = Random.Range (0.0f, 1.0f);
		designer_value = Random.Range (0.0f, 1.0f);
		document_value = Random.Range (0.0f, 1.0f);
		manager_slider.GetComponent<Slider> ().value = manager_value;
		programmer_slider.GetComponent<Slider> ().value = programmer_value;
		designer_slider.GetComponent<Slider> ().value = designer_value;
		document_slider.GetComponent<Slider> ().value = document_value;

	}

}
