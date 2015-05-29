using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileInput : MonoBehaviour {

	private RectTransform tileInputRect;
	private float tileInputWidth, tileInputHeight;

	public int slots;
	public float slotPaddingLeft, slotPaddingBottom;
	public float slotSize;
	public GameObject slotObject;

	private List<GameObject> tileSlots;

	
	// Use this for initialization
	void Start () {
		createLayout ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void createLayout() {
		tileSlots = new List<GameObject>();
		tileInputWidth = slots * (slotSize + slotPaddingLeft) + slotPaddingLeft;
		tileInputHeight = (slotSize + slotPaddingBottom) + slotPaddingBottom;
		tileInputRect = GetComponent<RectTransform> ();
		tileInputRect.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, tileInputWidth);
		tileInputRect.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, tileInputHeight);

		for (int i = 0; i < slots; i++) {
			float xPos = slotPaddingLeft*(i+1) + (slotSize*i);
			GameObject newSlot = (GameObject)Instantiate(slotObject);
			RectTransform slotRect = newSlot.GetComponent<RectTransform>();
			newSlot.name = "Slot";
			newSlot.transform.SetParent(this.transform.parent);
			slotRect.localPosition = tileInputRect.localPosition + new Vector3(xPos, -slotPaddingBottom, 0);
			slotRect.localScale = new Vector3(1, 1, 1);
			slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize);
			slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize);
			tileSlots.Add(newSlot);

		}
	}
}
