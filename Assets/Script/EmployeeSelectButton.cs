using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EmployeeSelectButton : MonoBehaviour {

	public GameObject selectButton;

	public GameObject[] manager_status;
	public GameObject[] programmer_status;
	public GameObject[] designer_status;
	public GameObject[] document_status;


	// Use this for initialization
	void Start () {
		Button emploemployeeSelectButton = selectButton.GetComponent<Button> ();

		emploemployeeSelectButton.onClick.AddListener (save_company_status);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void save_company_status() {
		float manager_value = 0;
		float programmer_value = 0;
		float designer_value = 0;
		float document_value = 0;
		foreach (var item in manager_status) {
			manager_value += item.GetComponent<Slider> ().value;
		}
		foreach (var item in programmer_status) {
			programmer_value += item.GetComponent<Slider> ().value;
		}
		foreach (var item in designer_status) {
			designer_value += item.GetComponent<Slider> ().value;
		}
		foreach (var item in document_status) {
			document_value += item.GetComponent<Slider> ().value;
		}
		PlayerPrefs.SetFloat ("global_manager_status", manager_value);
		PlayerPrefs.SetFloat ("global_programmer_status", programmer_value);
		PlayerPrefs.SetFloat ("global_designer_status", designer_value);
		PlayerPrefs.SetFloat ("global_document_status",document_value);

		Debug.Log (PlayerPrefs.GetFloat ("global_manager_status", 0));
	}

}
