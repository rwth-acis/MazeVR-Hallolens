using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class FocusHighlight : MonoBehaviour, IMixedRealityFocusHandler {

	// public color variables for editing in inspector
	public Color defaultColor = Color.green;
	public Color highlightColor = Color.red;

	private Renderer rend;
	private bool inside = false;

	// setting default color to object when starting game
	void Start () {
		defaultColor = Color.green;
		rend = gameObject.GetComponent<Renderer>();
		rend.material.color = defaultColor;
	}

	// used to be able to change colors with inspector while in game
	void Update () {
		if (inside == false){
			rend.material.color = defaultColor;
		}
	}

    // highlight color when gazing at object
    public void OnFocusEnter(FocusEventData eventData)
    {
        rend.material.color = highlightColor;
        inside = true;
    }

    // default color when not gazing at object
    public void OnFocusExit(FocusEventData eventData)
    {
        rend.material.color = defaultColor;
        inside = false;
    }
}