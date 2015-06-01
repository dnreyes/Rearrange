using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	#region IPointerEnterHandler implementation
	public void OnPointerEnter (PointerEventData eventData)
	{
		if (eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			d.placeholderParent = this.transform;
		}
	}

	#endregion

	#region IPointerExitHandler implementation
	public void OnPointerExit (PointerEventData eventData)
	{
		if (eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null && d.placeholderParent == this.transform) {
			d.placeholderParent = d.parentToReturnTo;
		}

	}

	#endregion

	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			d.parentToReturnTo = this.transform;
		}
	}
	#endregion
}
