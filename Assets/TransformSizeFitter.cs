using UnityEngine;
using UnityEngine.UI;

public class TransformSizeFitter : ContentSizeFitter
{
	[SerializeField] public RectTransform fitRect;

    private RectTransform rect;
    private RectTransform Rect
	{
        get
		{
            if (rect == null)
            {
                rect = GetComponent<RectTransform>();
            }

            return rect;
		}
	}

	public override void SetLayoutHorizontal()
	{
		base.SetLayoutHorizontal();
		FitInParent();
	}

	public override void SetLayoutVertical()
	{
		base.SetLayoutVertical();
		FitInParent();
	}



	private void FitInParent()
	{
		if (transform.parent == null)
		{
			return;
		}

		float rectWidth = Rect.rect.width;
		float rectHeight = Rect.rect.height;
		float parentWidth = fitRect.rect.width;
		float parentHeight = fitRect.rect.height;

		float width = Mathf.Clamp(rectWidth, 0, parentWidth);
		float height = Mathf.Clamp(rectHeight, 0, parentHeight);

		Rect.sizeDelta = new Vector2(width, height);
	}
}
